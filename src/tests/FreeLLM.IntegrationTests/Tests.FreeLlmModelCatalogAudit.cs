using Google.Gemini;
using System.Net.Http.Headers;
using System.Text.Json;
using tryAGI.OpenAI;

namespace FreeLLM.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("LiveModelAudit")]
    [DataRow("gemini")]
    [DataRow("cerebras")]
    [DataRow("sambanova")]
    [DataRow("github-models")]
    [DataRow("groq")]
    [DataRow("openrouter")]
    [DataRow("nvidia")]
    public async Task FreeLlmClient_LiveModelAudit_ListsAvailableModels(string providerId)
    {
        if (!ShouldRunLiveDiscovery())
        {
            throw new AssertInconclusiveException(
                "Live model audit is disabled. Set FREELLM_RUN_LIVE_DISCOVERY=1 to run provider model listing.");
        }

        var filter = Environment.GetEnvironmentVariable("FREELLM_MODEL_AUDIT_FILTER");
        IReadOnlyList<string> modelIds;

        if (string.Equals(providerId, "gemini", StringComparison.OrdinalIgnoreCase))
        {
            using var client = new GeminiClient(
                GetRequiredEnvironmentVariable("GEMINI_API_KEY", "GOOGLE_API_KEY", "GOOGLE_GEMINI_API_KEY"));
            modelIds = await ListGeminiModelsAsync(client).ConfigureAwait(false);
        }
        else
        {
            using var client = CreateLiveDiscoveryOpenAiClient(providerId);
            modelIds = await ListOpenAiCompatibleModelsAsync(client).ConfigureAwait(false);
        }

        var filteredModelIds = string.IsNullOrWhiteSpace(filter)
            ? modelIds
            : modelIds.Where(modelId => modelId.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToArray();

        TestContext.WriteLine($"Provider: {providerId}");
        TestContext.WriteLine($"Model count: {modelIds.Count}");
        TestContext.WriteLine($"Filter: {filter ?? "<none>"}");

        foreach (var presetModelId in GetPresetModelIds(providerId))
        {
            var isPresent = modelIds.Contains(presetModelId, StringComparer.OrdinalIgnoreCase);
            TestContext.WriteLine($"Preset check: {presetModelId} => {(isPresent ? "present" : "missing")}");
        }

        foreach (var modelId in filteredModelIds)
        {
            TestContext.WriteLine(modelId);
        }
    }

    private static OpenAiClient CreateLiveDiscoveryOpenAiClient(string providerId)
        => providerId switch
        {
            "cerebras" => CustomProviders.Cerebras(GetRequiredEnvironmentVariable("CEREBRAS_API_KEY")),
            "sambanova" => CustomProviders.SambaNova(GetRequiredEnvironmentVariable("SAMBANOVA_API_KEY")),
            "github-models" => CustomProviders.GitHubModels(GetRequiredEnvironmentVariable("TOKEN_FOR_GITHUB_MODELS", "GITHUB_TOKEN")),
            "groq" => CustomProviders.Groq(GetRequiredEnvironmentVariable("GROQ_API_KEY")),
            "openrouter" => CustomProviders.OpenRouter(GetRequiredEnvironmentVariable("OPENROUTER_API_KEY")),
            "nvidia" => CustomProviders.Nvidia(GetRequiredEnvironmentVariable("NVIDIA_API_KEY")),
            _ => throw new InvalidOperationException($"Unknown OpenAI-compatible provider '{providerId}'."),
        };

    private static async Task<IReadOnlyList<string>> ListOpenAiCompatibleModelsAsync(OpenAiClient client)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, BuildProviderUri(client, "models"));
        foreach (var authorization in client.Authorizations)
        {
            if (authorization.Type == "Http" || authorization.Type == "OAuth2")
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(
                    scheme: authorization.Name,
                    parameter: authorization.Value);
            }
            else if (authorization.Type == "ApiKey" && authorization.Location == "Header")
            {
                request.Headers.Add(authorization.Name, authorization.Value);
            }
        }

        using var response = await client.HttpClient.SendAsync(request).ConfigureAwait(false);
        var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return ParseOpenAiCompatibleModelIds(content);
    }

    private static async Task<IReadOnlyList<string>> ListGeminiModelsAsync(GeminiClient client)
    {
        var modelIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        string? pageToken = null;

        do
        {
            var response = await client.ModelsListAsync(pageSize: 100, pageToken: pageToken).ConfigureAwait(false);
            foreach (var model in response.Models ?? [])
            {
                if (model.BaseModelId is { Length: > 0 } baseModelId)
                {
                    modelIds.Add(baseModelId);
                }

                if (model.Name is { Length: > 0 } name)
                {
                    modelIds.Add(name);
                    if (name.StartsWith("models/", StringComparison.OrdinalIgnoreCase))
                    {
                        modelIds.Add(name["models/".Length..]);
                    }
                }
            }

            pageToken = response.NextPageToken;
        } while (pageToken is { Length: > 0 });

        return modelIds
            .OrderBy(static modelId => modelId, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static IReadOnlyList<string> GetPresetModelIds(string providerId)
        => providerId switch
        {
            "gemini" =>
            [
                "gemini-2.5-flash",
                "gemini-2.5-flash-lite",
            ],
            "cerebras" =>
            [
                "qwen-3-235b-a22b-instruct-2507",
                "llama3.1-8b",
            ],
            "sambanova" =>
            [
                "DeepSeek-R1-0528",
                "Meta-Llama-3.3-70B-Instruct",
                "Qwen3-32B",
            ],
            "github-models" =>
            [
                "gpt-4o",
                "gpt-4o-mini",
            ],
            "groq" =>
            [
                "openai/gpt-oss-120b",
                "llama-3.3-70b-versatile",
                "openai/gpt-oss-20b",
            ],
            "openrouter" =>
            [
                "openrouter/free",
                "meta-llama/llama-3.3-70b-instruct:free",
                "meta-llama/llama-3.2-3b-instruct:free",
            ],
            "nvidia" =>
            [
                "openai/gpt-oss-20b",
                "meta/llama-3.2-3b-instruct",
            ],
            _ => [],
        };

    private static IReadOnlyList<string> ParseOpenAiCompatibleModelIds(string json)
    {
        using var document = JsonDocument.Parse(json);
        var modelIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        CollectOpenAiCompatibleModelIds(document.RootElement, modelIds);

        return modelIds
            .OrderBy(static modelId => modelId, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static void CollectOpenAiCompatibleModelIds(JsonElement element, ISet<string> modelIds)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Array:
                foreach (var item in element.EnumerateArray())
                {
                    CollectOpenAiCompatibleModelIds(item, modelIds);
                }

                break;

            case JsonValueKind.Object:
                if (TryGetProperty(element, "data", out var dataElement) && dataElement.ValueKind == JsonValueKind.Array)
                {
                    CollectOpenAiCompatibleModelIds(dataElement, modelIds);
                    return;
                }

                if (TryGetProperty(element, "models", out var modelsElement) && modelsElement.ValueKind == JsonValueKind.Array)
                {
                    CollectOpenAiCompatibleModelIds(modelsElement, modelIds);
                    return;
                }

                var preferredId = GetPreferredModelId(element);
                if (!string.IsNullOrWhiteSpace(preferredId))
                {
                    modelIds.Add(preferredId);
                }

                break;
        }
    }

    private static string? GetPreferredModelId(JsonElement element)
    {
        var id = TryGetStringProperty(element, "id");
        var name = TryGetStringProperty(element, "name");

        if (id is { Length: > 0 } && !id.StartsWith("azureml://", StringComparison.OrdinalIgnoreCase))
        {
            return id;
        }

        if (name is { Length: > 0 })
        {
            return name;
        }

        return id;
    }

    private static string? TryGetStringProperty(JsonElement element, string propertyName)
        => TryGetProperty(element, propertyName, out var property) && property.ValueKind == JsonValueKind.String
            ? property.GetString()
            : null;

    private static Uri BuildProviderUri(OpenAiClient client, string relativePath)
    {
        var baseAddress = client.HttpClient.BaseAddress
            ?? throw new InvalidOperationException("The provider client does not have a base address configured.");

        var builder = new UriBuilder(baseAddress)
        {
            Path = $"{baseAddress.AbsolutePath.TrimEnd('/')}/{relativePath.TrimStart('/')}",
        };

        return builder.Uri;
    }

    private static bool TryGetProperty(JsonElement element, string propertyName, out JsonElement property)
    {
        foreach (var candidate in element.EnumerateObject())
        {
            if (string.Equals(candidate.Name, propertyName, StringComparison.OrdinalIgnoreCase))
            {
                property = candidate.Value;
                return true;
            }
        }

        property = default;
        return false;
    }
}
