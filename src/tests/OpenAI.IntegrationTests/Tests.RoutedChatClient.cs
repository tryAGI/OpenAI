using System.Net;
using System.Text;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task RoutedChatClient_UsesHighestPriorityAlias()
    {
        var lowerPriorityHandler = new FakeChatHandler(_ => FakeChatHandler.JsonResponse("lower-priority"));
        var higherPriorityHandler = new FakeChatHandler(_ => FakeChatHandler.JsonResponse("higher-priority"));

        using var lowerPriorityApi = CreateFakeApi(lowerPriorityHandler);
        using var higherPriorityApi = CreateFakeApi(higherPriorityHandler);
        using var routed = new OpenAiRoutedChatClientBuilder()
            .AddProvider("slow", lowerPriorityApi, provider => provider
                .AddModel("slow-model", model => model
                    .AsSmart(priority: 10)
                    .SupportsToolCalls()))
            .AddProvider("fast", higherPriorityApi, provider => provider
                .AddModel("fast-model", model => model
                    .AsSmart(priority: 20)
                    .SupportsToolCalls()))
            .Build();

        Meai.IChatClient chatClient = routed;
        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "hello")],
            new Meai.ChatOptions { ModelId = OpenAiModelAliases.Smart });

        response.Messages.Should().HaveCount(1);
        response.Messages[0].Text.Should().Be("higher-priority");
        higherPriorityHandler.RequestCount.Should().Be(1);
        lowerPriorityHandler.RequestCount.Should().Be(0);
    }

    [TestMethod]
    public async Task RoutedChatClient_FallsBackOn429_AndTracksCooldown()
    {
        var timeProvider = new FakeTimeProvider(new DateTimeOffset(2026, 4, 1, 0, 0, 0, TimeSpan.Zero));
        var rateLimitedHandler = new FakeChatHandler(_ =>
            new HttpResponseMessage(HttpStatusCode.TooManyRequests)
            {
                Content = new StringContent("rate limited", Encoding.UTF8, "text/plain"),
                Headers =
                {
                    { "Retry-After", "120" },
                    { "x-ratelimit-remaining-requests", "0" },
                },
            });
        var fallbackHandler = new FakeChatHandler(_ => FakeChatHandler.JsonResponse("fallback"));

        using var rateLimitedApi = CreateFakeApi(rateLimitedHandler);
        using var fallbackApi = CreateFakeApi(fallbackHandler);
        using var routed = new OpenAiRoutedChatClientBuilder()
            .WithTimeProvider(timeProvider)
            .AddProvider("primary", rateLimitedApi, provider => provider
                .AddModel("primary-model", model => model.AsSmart(priority: 100).IsRecurringFree()))
            .AddProvider("fallback", fallbackApi, provider => provider
                .AddModel("fallback-model", model => model.AsSmart(priority: 10).IsRecurringFree()))
            .Build();

        Meai.IChatClient chatClient = routed;

        var firstResponse = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "hello")],
            new Meai.ChatOptions { ModelId = OpenAiModelAliases.Smart });

        firstResponse.Messages[0].Text.Should().Be("fallback");
        rateLimitedHandler.RequestCount.Should().Be(1);
        fallbackHandler.RequestCount.Should().Be(1);

        var statusAfter429 = routed.GetProviderStatuses()
            .Single(status => status.ProviderId == "primary");
        statusAfter429.CooldownUntil.Should().Be(timeProvider.GetUtcNow().AddSeconds(120));
        statusAfter429.RateLimitSnapshot.Should().NotBeNull();
        statusAfter429.RateLimitSnapshot!.RemainingRequests.Should().Be(0);

        timeProvider.Advance(TimeSpan.FromSeconds(30));

        var secondResponse = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "hello again")],
            new Meai.ChatOptions { ModelId = OpenAiModelAliases.Smart });

        secondResponse.Messages[0].Text.Should().Be("fallback");
        rateLimitedHandler.RequestCount.Should().Be(1);
        fallbackHandler.RequestCount.Should().Be(2);

        timeProvider.Advance(TimeSpan.FromSeconds(120));

        var thirdResponse = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "try again")],
            new Meai.ChatOptions { ModelId = OpenAiModelAliases.Smart });

        thirdResponse.Messages[0].Text.Should().Be("fallback");
        rateLimitedHandler.RequestCount.Should().Be(2);
        fallbackHandler.RequestCount.Should().Be(3);
    }

    [TestMethod]
    public async Task RoutedChatClient_SkipsToolIncompatibleModels()
    {
        var skippedHandler = new FakeChatHandler(_ => FakeChatHandler.JsonResponse("should-not-run"));
        var toolCapableHandler = new FakeChatHandler(_ => FakeChatHandler.JsonResponse("tool-capable"));

        using var skippedApi = CreateFakeApi(skippedHandler);
        using var toolCapableApi = CreateFakeApi(toolCapableHandler);
        using var routed = new OpenAiRoutedChatClientBuilder()
            .AddProvider("notools", skippedApi, provider => provider
                .AddModel("plain-model", model => model
                    .AsSmart(priority: 100)
                    .SupportsToolCalls(false)))
            .AddProvider("tools", toolCapableApi, provider => provider
                .AddModel("tool-model", model => model
                    .AsSmart(priority: 10)
                    .SupportsToolCalls()))
            .Build();

        var tool = Meai.AIFunctionFactory.Create(
            (string city) => $"Weather for {city}",
            name: "GetWeather");

        Meai.IChatClient chatClient = routed;
        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Use the weather tool.")],
            new Meai.ChatOptions
            {
                ModelId = OpenAiModelAliases.Smart,
                Tools = [tool],
            });

        response.Messages[0].Text.Should().Be("tool-capable");
        skippedHandler.RequestCount.Should().Be(0);
        toolCapableHandler.RequestCount.Should().Be(1);
    }

    private static OpenAiClient CreateFakeApi(FakeChatHandler handler)
    {
        var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://example.test/v1/"),
        };

        return new OpenAiClient(
            apiKey: "test-key",
            httpClient: httpClient,
            disposeHttpClient: true);
    }

    private sealed class FakeChatHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _responseFactory;

        public FakeChatHandler(Func<HttpRequestMessage, HttpResponseMessage> responseFactory)
        {
            _responseFactory = responseFactory;
        }

        public int RequestCount { get; private set; }

        public static HttpResponseMessage JsonResponse(string content)
        {
            var payload = JsonSerializer.Serialize(new
            {
                id = "chatcmpl-test",
                @object = "chat.completion",
                created = 1_711_936_000,
                model = "test-model",
                choices = new[]
                {
                    new
                    {
                        index = 0,
                        message = new
                        {
                            role = "assistant",
                            content,
                        },
                        finish_reason = "stop",
                    },
                },
                usage = new
                {
                    prompt_tokens = 1,
                    completion_tokens = 1,
                    total_tokens = 2,
                },
            });

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(payload, Encoding.UTF8, "application/json"),
            };
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            RequestCount++;
            return Task.FromResult(_responseFactory(request));
        }
    }
}
