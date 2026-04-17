using System.Net;
using System.Text;
using FreeLLM;

namespace FreeLLM.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow("cerebras", FreeLlmModelAliases.Smart, "qwen-3-235b-a22b-instruct-2507")]
    [DataRow("cerebras", FreeLlmModelAliases.SmartAny, "qwen-3-235b-a22b-instruct-2507")]
    [DataRow("cerebras", FreeLlmModelAliases.Fast, "llama3.1-8b")]
    [DataRow("cerebras", FreeLlmModelAliases.Cheap, "llama3.1-8b")]
    [DataRow("sambanova", FreeLlmModelAliases.Smart, "DeepSeek-R1-0528")]
    [DataRow("sambanova", FreeLlmModelAliases.Fast, "Meta-Llama-3.3-70B-Instruct")]
    [DataRow("sambanova", FreeLlmModelAliases.Cheap, "Qwen3-32B")]
    [DataRow("openrouter", FreeLlmModelAliases.SmartAny, "meta-llama/llama-3.3-70b-instruct:free")]
    [DataRow("openrouter", FreeLlmModelAliases.Fast, "meta-llama/llama-3.2-3b-instruct:free")]
    [DataRow("openrouter", FreeLlmModelAliases.Cheap, "openrouter/free")]
    [DataRow("github-models", FreeLlmModelAliases.Smart, "gpt-4o")]
    [DataRow("github-models", FreeLlmModelAliases.SmartAny, "gpt-4o")]
    [DataRow("github-models", FreeLlmModelAliases.Fast, "gpt-4o-mini")]
    [DataRow("github-models", FreeLlmModelAliases.Cheap, "gpt-4o-mini")]
    [DataRow("groq", FreeLlmModelAliases.Smart, "openai/gpt-oss-120b")]
    [DataRow("groq", FreeLlmModelAliases.Fast, "llama-3.3-70b-versatile")]
    [DataRow("groq", FreeLlmModelAliases.Cheap, "openai/gpt-oss-20b")]
    [DataRow("nvidia", FreeLlmModelAliases.SmartAny, "openai/gpt-oss-20b")]
    [DataRow("nvidia", FreeLlmModelAliases.Fast, "meta/llama-3.2-3b-instruct")]
    [DataRow("nvidia", FreeLlmModelAliases.Cheap, "meta/llama-3.2-3b-instruct")]
    public async Task FreeLlmClient_UsesPresetModels_ForPopularProviders(string providerId, string alias, string expectedModelId)
    {
        var handler = new FakeOpenAiChatHandler(request =>
            FakeOpenAiChatHandler.JsonResponse(GetRequestedModelId(request)));

        using var client = CreatePresetOpenAiCompatibleClient(providerId, handler);

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(alias, "hello"));

        response.Choices[0].Message.Content.Should().Be(expectedModelId);
    }

    [TestMethod]
    public async Task FreeLlmClient_TracksGenericRateLimitHeaders_OnSuccessfulResponses()
    {
        var timeProvider = new FakeTimeProvider(new DateTimeOffset(2026, 4, 1, 0, 0, 0, TimeSpan.Zero));
        var handler = new FakeOpenAiChatHandler(_ =>
        {
            var response = FakeOpenAiChatHandler.JsonResponse("ok");
            response.Headers.Add("RateLimit-Remaining", "7");
            response.Headers.Add("RateLimit-Limit", "10");
            response.Headers.Add("RateLimit-Reset", "120");
            response.Headers.Add("x-provider-ratelimit-window", "minute");
            return response;
        });

        using var client = new FreeLlmClientBuilder()
            .WithTimeProvider(timeProvider)
            .AddOpenAiCompatible(
                "provider",
                "test-key",
                new Uri("https://example.test/v1/"),
                provider => provider.AddModel("test-model", model => model.AsSmart(priority: 100)),
                messageHandler: handler)
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));

        response.Choices[0].Message.Content.Should().Be("ok");

        var status = client.GetProviderStatuses().Single(static status => status.ProviderId == "provider");
        status.RateLimitSnapshot.Should().NotBeNull();
        status.RateLimitSnapshot!.RemainingRequests.Should().Be(7);
        status.RateLimitSnapshot.LimitRequests.Should().Be(10);
        status.RateLimitSnapshot.ResetAt.Should().Be(timeProvider.GetUtcNow().AddSeconds(120));
        status.RateLimitSnapshot.ObservedHeaders.Keys.Should().Contain("RateLimit-Remaining");
        status.RateLimitSnapshot.ObservedHeaders.Keys.Should().Contain("RateLimit-Limit");
        status.RateLimitSnapshot.ObservedHeaders.Keys.Should().Contain("RateLimit-Reset");
        status.RateLimitSnapshot.ObservedHeaders.Keys.Should().Contain("x-provider-ratelimit-window");
    }

    [TestMethod]
    public async Task FreeLlmClient_UsesRetryAfterMilliseconds_ForCooldown()
    {
        var timeProvider = new FakeTimeProvider(new DateTimeOffset(2026, 4, 1, 0, 0, 0, TimeSpan.Zero));
        var rateLimitedHandler = new FakeOpenAiChatHandler(_ =>
            new HttpResponseMessage(HttpStatusCode.TooManyRequests)
            {
                Content = new StringContent("rate limited", Encoding.UTF8, "text/plain"),
                Headers =
                {
                    { "retry-after-ms", "1500" },
                    { "x-provider-ratelimit-bucket", "trial" },
                },
            });
        var fallbackHandler = new FakeOpenAiChatHandler(_ => FakeOpenAiChatHandler.JsonResponse("fallback"));

        using var client = new FreeLlmClientBuilder()
            .WithTimeProvider(timeProvider)
            .AddOpenAiCompatible(
                "primary",
                "test-key",
                new Uri("https://example.test/v1/"),
                provider => provider.AddModel("primary-model", model => model.AsSmart(priority: 100)),
                messageHandler: rateLimitedHandler)
            .AddOpenAiCompatible(
                "fallback",
                "test-key",
                new Uri("https://example.test/v1/"),
                provider => provider.AddModel("fallback-model", model => model.AsSmart(priority: 10)),
                messageHandler: fallbackHandler)
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));

        response.Choices[0].Message.Content.Should().Be("fallback");

        var status = client.GetProviderStatuses().Single(static status => status.ProviderId == "primary");
        status.CooldownUntil.Should().Be(timeProvider.GetUtcNow().AddMilliseconds(1500));
        status.RateLimitSnapshot.Should().NotBeNull();
        status.RateLimitSnapshot!.RetryAfter.Should().Be(TimeSpan.FromMilliseconds(1500));
        status.RateLimitSnapshot.ObservedHeaders.Keys.Should().Contain("retry-after-ms");
        status.RateLimitSnapshot.ObservedHeaders.Keys.Should().Contain("x-provider-ratelimit-bucket");
    }

    [TestMethod]
    public async Task FreeLlmClient_CapturesUnparsedRateLimitHeaders_ForDiagnostics()
    {
        var handler = new FakeOpenAiChatHandler(_ =>
        {
            var response = FakeOpenAiChatHandler.JsonResponse("ok");
            response.Headers.Add("x-nvidia-ratelimit-scope", "free-endpoint");
            response.Headers.Add("x-nvidia-ratelimit-window", "minute");
            return response;
        });

        using var client = new FreeLlmClientBuilder()
            .AddOpenAiCompatible(
                "provider",
                "test-key",
                new Uri("https://example.test/v1/"),
                provider => provider.AddModel("test-model", model => model.AsSmart(priority: 100)),
                messageHandler: handler)
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));

        response.Choices[0].Message.Content.Should().Be("ok");

        var status = client.GetProviderStatuses().Single(static status => status.ProviderId == "provider");
        status.RateLimitSnapshot.Should().NotBeNull();
        status.RateLimitSnapshot!.RemainingRequests.Should().BeNull();
        status.RateLimitSnapshot.LimitRequests.Should().BeNull();
        status.RateLimitSnapshot.RetryAfter.Should().BeNull();
        status.RateLimitSnapshot.ResetAt.Should().BeNull();
        status.RateLimitSnapshot.ObservedHeaders.Keys.Should().Contain("x-nvidia-ratelimit-scope");
        status.RateLimitSnapshot.ObservedHeaders.Keys.Should().Contain("x-nvidia-ratelimit-window");
    }

    private static FreeLlmClient CreatePresetOpenAiCompatibleClient(string providerId, FakeOpenAiChatHandler handler)
    {
        var builder = new FreeLlmClientBuilder();

        return providerId switch
        {
            "cerebras" => builder.AddCerebras("test-key", messageHandler: handler).Build(),
            "sambanova" => builder.AddSambaNova("test-key", messageHandler: handler).Build(),
            "openrouter" => builder.AddOpenRouter("test-key", messageHandler: handler).Build(),
            "github-models" => builder.AddGitHubModels("test-key", messageHandler: handler).Build(),
            "groq" => builder.AddGroq("test-key", messageHandler: handler).Build(),
            "nvidia" => builder.AddNvidia("test-key", messageHandler: handler).Build(),
            _ => throw new InvalidOperationException($"Unknown provider '{providerId}'."),
        };
    }
}
