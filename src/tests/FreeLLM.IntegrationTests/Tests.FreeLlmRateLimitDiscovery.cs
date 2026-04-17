using FreeLLM;

namespace FreeLLM.IntegrationTests;

public partial class Tests
{
    private static int _isDotEnvLoaded;

    public TestContext TestContext { get; set; } = default!;

    [TestMethod]
    [TestCategory("LiveDiscovery")]
    [DataRow("gemini", FreeLlmModelAliases.Smart)]
    [DataRow("cerebras", FreeLlmModelAliases.Smart)]
    [DataRow("sambanova", FreeLlmModelAliases.Smart)]
    [DataRow("github-models", FreeLlmModelAliases.Smart)]
    [DataRow("groq", FreeLlmModelAliases.Smart)]
    [DataRow("nvidia", FreeLlmModelAliases.SmartAny)]
    [DataRow("openrouter", FreeLlmModelAliases.SmartAny)]
    public async Task FreeLlmClient_LiveDiscovery_WritesObservedRateLimitSignals(string providerId, string alias)
    {
        if (!ShouldRunLiveDiscovery())
        {
            throw new AssertInconclusiveException(
                "Live discovery is disabled. Set FREELLM_RUN_LIVE_DISCOVERY=1 to run provider probes.");
        }

        using var client = CreateLiveDiscoveryClient(providerId);

        try
        {
            var requestModelId = GetLiveDiscoveryRequestModel(providerId, alias);
            var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(requestModelId, "Reply with OK."));
            response.Choices.Should().HaveCount(1);
        }
        finally
        {
            WriteObservedProviderStatus(providerId, client);
        }
    }

    private static FreeLlmClient CreateLiveDiscoveryClient(string providerId)
    {
        LoadDotEnv();

        var builder = new FreeLlmClientBuilder();

        return providerId switch
        {
            "gemini" => builder.AddGemini(GetRequiredEnvironmentVariable("GEMINI_API_KEY", "GOOGLE_API_KEY", "GOOGLE_GEMINI_API_KEY")).Build(),
            "cerebras" => builder.AddCerebras(GetRequiredEnvironmentVariable("CEREBRAS_API_KEY")).Build(),
            "sambanova" => builder.AddSambaNova(GetRequiredEnvironmentVariable("SAMBANOVA_API_KEY")).Build(),
            "github-models" => builder.AddGitHubModels(GetRequiredEnvironmentVariable("TOKEN_FOR_GITHUB_MODELS", "GITHUB_TOKEN")).Build(),
            "groq" => builder.AddGroq(GetRequiredEnvironmentVariable("GROQ_API_KEY")).Build(),
            "nvidia" => builder.AddNvidia(GetRequiredEnvironmentVariable("NVIDIA_API_KEY")).Build(),
            "openrouter" => builder.AddOpenRouter(GetRequiredEnvironmentVariable("OPENROUTER_API_KEY")).Build(),
            _ => throw new InvalidOperationException($"Unknown provider '{providerId}'."),
        };
    }

    private static string GetRequiredEnvironmentVariable(params string[] names)
    {
        LoadDotEnv();

        foreach (var name in names)
        {
            if (Environment.GetEnvironmentVariable(name) is { Length: > 0 } value)
            {
                return value;
            }
        }

        throw new AssertInconclusiveException(
            $"One of the following environment variables is required: {string.Join(", ", names)}.");
    }

    private void WriteObservedProviderStatus(string providerId, FreeLlmClient client)
    {
        var status = client.GetProviderStatuses().Single(status =>
            string.Equals(status.ProviderId, providerId, StringComparison.OrdinalIgnoreCase));

        TestContext.WriteLine($"Provider: {providerId}");
        TestContext.WriteLine($"LastError: {status.LastError ?? "<none>"}");
        TestContext.WriteLine($"CooldownUntil: {status.CooldownUntil?.ToString("O") ?? "<none>"}");

        if (status.RateLimitSnapshot is null)
        {
            TestContext.WriteLine("RateLimitSnapshot: <none>");
            return;
        }

        TestContext.WriteLine($"RetryAfter: {status.RateLimitSnapshot.RetryAfter?.ToString() ?? "<none>"}");
        TestContext.WriteLine($"ResetAt: {status.RateLimitSnapshot.ResetAt?.ToString("O") ?? "<none>"}");
        TestContext.WriteLine($"RemainingRequests: {status.RateLimitSnapshot.RemainingRequests?.ToString() ?? "<none>"}");
        TestContext.WriteLine($"LimitRequests: {status.RateLimitSnapshot.LimitRequests?.ToString() ?? "<none>"}");
        TestContext.WriteLine($"RemainingTokens: {status.RateLimitSnapshot.RemainingTokens?.ToString() ?? "<none>"}");
        TestContext.WriteLine($"LimitTokens: {status.RateLimitSnapshot.LimitTokens?.ToString() ?? "<none>"}");

        foreach (var header in status.RateLimitSnapshot.ObservedHeaders.OrderBy(static header => header.Key, StringComparer.OrdinalIgnoreCase))
        {
            TestContext.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
        }
    }

    private static bool ShouldRunLiveDiscovery()
        => string.Equals(
            Environment.GetEnvironmentVariable("FREELLM_RUN_LIVE_DISCOVERY"),
            "1",
            StringComparison.Ordinal);

    private static string GetLiveDiscoveryRequestModel(string providerId, string fallbackAlias)
        => Environment.GetEnvironmentVariable(GetProviderModelOverrideVariableName(providerId)) is { Length: > 0 } modelId
            ? modelId
            : fallbackAlias;

    private static string GetProviderModelOverrideVariableName(string providerId)
        => providerId switch
        {
            "gemini" => "FREELLM_GEMINI_MODEL_ID",
            "cerebras" => "FREELLM_CEREBRAS_MODEL_ID",
            "sambanova" => "FREELLM_SAMBANOVA_MODEL_ID",
            "github-models" => "FREELLM_GITHUB_MODELS_MODEL_ID",
            "groq" => "FREELLM_GROQ_MODEL_ID",
            "nvidia" => "FREELLM_NVIDIA_MODEL_ID",
            "openrouter" => "FREELLM_OPENROUTER_MODEL_ID",
            _ => "FREELLM_MODEL_ID",
        };

    private static void LoadDotEnv()
    {
        if (Interlocked.Exchange(ref _isDotEnvLoaded, 1) == 1)
        {
            return;
        }

        foreach (var startDirectory in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
        {
            var dotEnvPath = FindFileInAncestors(startDirectory, ".env");
            if (dotEnvPath is null)
            {
                continue;
            }

            foreach (var rawLine in File.ReadLines(dotEnvPath))
            {
                var line = rawLine.Trim();
                if (line.Length == 0 || line.StartsWith('#'))
                {
                    continue;
                }

                if (line.StartsWith("export ", StringComparison.Ordinal))
                {
                    line = line["export ".Length..].TrimStart();
                }

                var separatorIndex = line.IndexOf('=');
                if (separatorIndex <= 0)
                {
                    continue;
                }

                var key = line[..separatorIndex].Trim();
                if (key.Length == 0 || Environment.GetEnvironmentVariable(key) is not null)
                {
                    continue;
                }

                var value = line[(separatorIndex + 1)..].Trim();
                if (value.Length >= 2 &&
                    ((value[0] == '"' && value[^1] == '"') || (value[0] == '\'' && value[^1] == '\'')))
                {
                    value = value[1..^1];
                }

                Environment.SetEnvironmentVariable(key, value);
            }

            return;
        }
    }

    private static string? FindFileInAncestors(string startDirectory, string fileName)
    {
        var directory = new DirectoryInfo(Path.GetFullPath(startDirectory));
        while (directory is not null)
        {
            var candidate = Path.Combine(directory.FullName, fileName);
            if (File.Exists(candidate))
            {
                return candidate;
            }

            directory = directory.Parent;
        }

        return null;
    }
}
