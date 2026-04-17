using System.Net;
using System.Text;
using System.Text.Json;
using Google.Gemini;
using FreeLLM;
using Meai = Microsoft.Extensions.AI;

namespace FreeLLM.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public async Task FreeLlmClient_UsesHighestPriorityAlias_ForOpenAiCompatibleRequest()
    {
        var lowerPriorityHandler = new FakeOpenAiChatHandler(_ => FakeOpenAiChatHandler.JsonResponse("lower-priority"));
        var higherPriorityHandler = new FakeOpenAiChatHandler(_ => FakeOpenAiChatHandler.JsonResponse("higher-priority"));

        using var lowerPriorityClient = CreateFakeOpenAiClient(lowerPriorityHandler);
        using var higherPriorityClient = CreateFakeOpenAiClient(higherPriorityHandler);
        using var client = new FreeLlmClientBuilder()
            .AddOpenAiCompatibleProvider("slow", lowerPriorityClient, provider => provider
                .AddModel("slow-model", model => model
                    .AsSmart(priority: 10)
                    .SupportsToolCalls()))
            .AddOpenAiCompatibleProvider("fast", higherPriorityClient, provider => provider
                .AddModel("fast-model", model => model
                    .AsSmart(priority: 20)
                    .SupportsToolCalls()))
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));

        response.Choices.Should().HaveCount(1);
        response.Choices[0].Message.Content.Should().Be("higher-priority");
        higherPriorityHandler.RequestCount.Should().Be(1);
        lowerPriorityHandler.RequestCount.Should().Be(0);
    }

    [TestMethod]
    public async Task FreeLlmClient_UsesProviderPriority_AsRouteBias()
    {
        var lowerPriorityHandler = new FakeOpenAiChatHandler(_ => FakeOpenAiChatHandler.JsonResponse("lower-provider"));
        var higherPriorityHandler = new FakeOpenAiChatHandler(_ => FakeOpenAiChatHandler.JsonResponse("higher-provider"));

        using var lowerPriorityClient = CreateFakeOpenAiClient(lowerPriorityHandler);
        using var higherPriorityClient = CreateFakeOpenAiClient(higherPriorityHandler);
        using var client = new FreeLlmClientBuilder()
            .AddOpenAiCompatibleProvider("secondary", lowerPriorityClient, provider => provider
                .WithPriority(10)
                .AddModel("secondary-model", model => model.AsSmart(priority: 100)))
            .AddOpenAiCompatibleProvider("primary", higherPriorityClient, provider => provider
                .WithPriority(50)
                .AddModel("primary-model", model => model.AsSmart(priority: 100)))
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));

        response.Choices[0].Message.Content.Should().Be("higher-provider");
        higherPriorityHandler.RequestCount.Should().Be(1);
        lowerPriorityHandler.RequestCount.Should().Be(0);
    }

    [TestMethod]
    public async Task FreeLlmClient_UsesAliasSpecificModelPriorities()
    {
        var handler = new FakeOpenAiChatHandler(request =>
        {
            var modelId = GetRequestedModelId(request);
            return modelId switch
            {
                "smart-model" => FakeOpenAiChatHandler.JsonResponse("smart-response"),
                "cheap-model" => FakeOpenAiChatHandler.JsonResponse("cheap-response"),
                _ => throw new InvalidOperationException($"Unexpected model '{modelId}'."),
            };
        });

        using var openAiClient = CreateFakeOpenAiClient(handler);
        using var client = new FreeLlmClientBuilder()
            .AddOpenAiCompatibleProvider("provider", openAiClient, provider => provider
                .AddModel("smart-model", model => model
                    .AsSmart(priority: 200)
                    .AsCheap(priority: 10))
                .AddModel("cheap-model", model => model
                    .AsSmart(priority: 10)
                    .AsCheap(priority: 200)))
            .Build();

        var smartResponse = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));
        var cheapResponse = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Cheap, "hello"));

        smartResponse.Choices[0].Message.Content.Should().Be("smart-response");
        cheapResponse.Choices[0].Message.Content.Should().Be("cheap-response");
    }

    [TestMethod]
    public async Task FreeLlmClient_RoutesOpenAiCompatibleRequest_ToGemini()
    {
        var geminiHandler = new FakeGeminiHandler(_ => FakeGeminiHandler.JsonResponse("gemini-response"));

        using var geminiClient = CreateFakeGeminiClient(geminiHandler);
        using var client = new FreeLlmClientBuilder()
            .AddGeminiProvider("gemini", geminiClient, provider => provider
                .AddModel("gemini-2.5-flash", model => model
                    .AsSmart(priority: 100)
                    .SupportsStructuredOutputs()
                    .SupportsStreaming()))
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest("gemini-2.5-flash", "hello"));

        response.Choices.Should().HaveCount(1);
        response.Choices[0].Message.Content.Should().Be("gemini-response");
        geminiHandler.RequestCount.Should().Be(1);
        geminiHandler.LastRequestUri.Should().NotBeNull();
        geminiHandler.LastRequestUri!.AbsolutePath.Should().Contain("models/gemini-2.5-flash");
    }

    [TestMethod]
    public async Task FreeLlmClient_UsesGeminiPresetModels_ForConvenienceMethod()
    {
        var geminiHandler = new FakeGeminiHandler(_ => FakeGeminiHandler.JsonResponse("gemini-preset"));

        using var client = new FreeLlmClientBuilder()
            .AddGemini("test-key", messageHandler: geminiHandler)
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Fast, "hello"));

        response.Choices[0].Message.Content.Should().Be("gemini-preset");
        geminiHandler.RequestCount.Should().Be(1);
        geminiHandler.LastRequestUri.Should().NotBeNull();
        geminiHandler.LastRequestUri!.AbsolutePath.Should().Contain("models/gemini-2.5-flash-lite");
    }

    [TestMethod]
    public async Task FreeLlmClient_UpdatesPresetModels_InPlace()
    {
        var geminiHandler = new FakeGeminiHandler(request =>
        {
            var modelId = GetRequestedModelIdFromGeminiRequest(request);
            return modelId switch
            {
                "gemini-2.5-flash" => FakeGeminiHandler.JsonResponse("flash-override"),
                "gemini-2.5-flash-lite" => FakeGeminiHandler.JsonResponse("flash-lite-default"),
                _ => throw new InvalidOperationException($"Unexpected Gemini model '{modelId}'."),
            };
        });

        using var client = new FreeLlmClientBuilder()
            .AddGemini(
                "test-key",
                provider => provider.AddModel("gemini-2.5-flash", model => model.AsCheap(priority: 500)),
                messageHandler: geminiHandler)
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Cheap, "hello"));

        response.Choices[0].Message.Content.Should().Be("flash-override");
        geminiHandler.LastRequestUri.Should().NotBeNull();
        geminiHandler.LastRequestUri!.AbsolutePath.Should().Contain("models/gemini-2.5-flash");
    }

    [TestMethod]
    public async Task FreeLlmClient_CanDisableDefaultPresetModels()
    {
        var geminiHandler = new FakeGeminiHandler(_ => FakeGeminiHandler.JsonResponse("manual-only"));

        using var client = new FreeLlmClientBuilder()
            .AddGemini(
                "test-key",
                provider => provider.AddModel("gemini-2.5-flash-lite", model => model.AsCheap(priority: 300)),
                messageHandler: geminiHandler,
                useDefaultModels: false)
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Cheap, "hello"));
        response.Choices[0].Message.Content.Should().Be("manual-only");

        var assertion = await FluentActions.Invoking(async () =>
                await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello")))
            .Should()
            .ThrowAsync<InvalidOperationException>();
        var exception = assertion.Which;
        exception.Message.Should().Contain("No routed models matched");
    }

    [TestMethod]
    public async Task FreeLlmClient_UsesPresetModels_ForMeaiSurface()
    {
        var geminiHandler = new FakeGeminiHandler(_ => FakeGeminiHandler.JsonResponse("meai-fast"));

        using var client = new FreeLlmClientBuilder()
            .AddGemini("test-key", messageHandler: geminiHandler)
            .Build();

        Meai.IChatClient chatClient = client;
        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "hello")],
            new Meai.ChatOptions { ModelId = FreeLlmModelAliases.Fast });

        response.Messages[0].Text.Should().Be("meai-fast");
        geminiHandler.LastRequestUri.Should().NotBeNull();
        geminiHandler.LastRequestUri!.AbsolutePath.Should().Contain("models/gemini-2.5-flash-lite");
    }

    [TestMethod]
    public async Task FreeLlmClient_FallsBackOn429_AndTracksCooldown_AcrossProviders()
    {
        var timeProvider = new FakeTimeProvider(new DateTimeOffset(2026, 4, 1, 0, 0, 0, TimeSpan.Zero));
        var rateLimitedHandler = new FakeOpenAiChatHandler(_ =>
            new HttpResponseMessage(HttpStatusCode.TooManyRequests)
            {
                Content = new StringContent("rate limited", Encoding.UTF8, "text/plain"),
                Headers =
                {
                    { "Retry-After", "120" },
                    { "x-ratelimit-remaining-requests", "0" },
                },
            });
        var geminiHandler = new FakeGeminiHandler(_ => FakeGeminiHandler.JsonResponse("gemini-fallback"));

        using var primaryClient = CreateFakeOpenAiClient(rateLimitedHandler);
        using var fallbackClient = CreateFakeGeminiClient(geminiHandler);
        using var client = new FreeLlmClientBuilder()
            .WithTimeProvider(timeProvider)
            .AddOpenAiCompatibleProvider("primary", primaryClient, provider => provider
                .AddModel("primary-model", model => model
                    .AsSmart(priority: 100)
                    .IsRecurringFree()))
            .AddGeminiProvider("gemini", fallbackClient, provider => provider
                .AddModel("gemini-2.5-flash", model => model
                    .AsSmart(priority: 10)
                    .IsRecurringFree()))
            .Build();

        var firstResponse = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));

        firstResponse.Choices[0].Message.Content.Should().Be("gemini-fallback");
        rateLimitedHandler.RequestCount.Should().Be(1);
        geminiHandler.RequestCount.Should().Be(1);

        var statusAfter429 = client.GetProviderStatuses()
            .Single(status => status.ProviderId == "primary");
        statusAfter429.CooldownUntil.Should().Be(timeProvider.GetUtcNow().AddSeconds(120));
        statusAfter429.RateLimitSnapshot.Should().NotBeNull();
        statusAfter429.RateLimitSnapshot!.RemainingRequests.Should().Be(0);

        timeProvider.Advance(TimeSpan.FromSeconds(30));

        var secondResponse = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello again"));

        secondResponse.Choices[0].Message.Content.Should().Be("gemini-fallback");
        rateLimitedHandler.RequestCount.Should().Be(1);
        geminiHandler.RequestCount.Should().Be(2);

        timeProvider.Advance(TimeSpan.FromSeconds(120));

        var thirdResponse = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "try again"));

        thirdResponse.Choices[0].Message.Content.Should().Be("gemini-fallback");
        rateLimitedHandler.RequestCount.Should().Be(2);
        geminiHandler.RequestCount.Should().Be(3);
    }

    private static tryAGI.OpenAI.CreateChatCompletionRequest CreateRawRequest(string modelId, string prompt)
        => new()
        {
            CreateChatCompletionRequestVariant2 = new tryAGI.OpenAI.CreateChatCompletionRequestVariant2
            {
                Model = modelId,
                Messages =
                [
                    prompt,
                ],
            },
        };

    private static string GetRequestedModelId(HttpRequestMessage request)
    {
        var json = request.Content?.ReadAsStringAsync().GetAwaiter().GetResult()
                   ?? throw new InvalidOperationException("Missing request content.");
        using var document = JsonDocument.Parse(json);
        return document.RootElement.GetProperty("model").GetString()
               ?? throw new InvalidOperationException("Missing model id.");
    }

    private static string GetRequestedModelIdFromGeminiRequest(HttpRequestMessage request)
    {
        var path = request.RequestUri?.AbsolutePath
                   ?? throw new InvalidOperationException("Missing Gemini request uri.");
        const string marker = "/models/";
        var markerIndex = path.IndexOf(marker, StringComparison.Ordinal);
        markerIndex.Should().NotBe(-1);

        var modelStart = markerIndex + marker.Length;
        var actionIndex = path.IndexOf(':', modelStart);
        return actionIndex >= 0 ? path[modelStart..actionIndex] : path[modelStart..];
    }

    private static tryAGI.OpenAI.OpenAiClient CreateFakeOpenAiClient(FakeOpenAiChatHandler handler)
    {
        var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://example.test/v1/"),
        };

        return new tryAGI.OpenAI.OpenAiClient(httpClient: httpClient, options: null, disposeHttpClient: true);
    }

    private static GeminiClient CreateFakeGeminiClient(HttpMessageHandler handler)
    {
        var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri(GeminiClient.DefaultBaseUrl),
        };

        return new GeminiClient(
            apiKey: "test-key",
            httpClient: httpClient,
            disposeHttpClient: true);
    }

    private sealed class FakeOpenAiChatHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _responseFactory;

        public FakeOpenAiChatHandler(Func<HttpRequestMessage, HttpResponseMessage> responseFactory)
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

    private sealed class FakeGeminiHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _responseFactory;

        public FakeGeminiHandler(Func<HttpRequestMessage, HttpResponseMessage> responseFactory)
        {
            _responseFactory = responseFactory;
        }

        public int RequestCount { get; private set; }

        public Uri? LastRequestUri { get; private set; }

        public static HttpResponseMessage JsonResponse(string content)
        {
            var payload = JsonSerializer.Serialize(new
            {
                responseId = "gemini-response-id",
                modelVersion = "gemini-2.5-flash",
                candidates = new[]
                {
                    new
                    {
                        content = new
                        {
                            role = "model",
                            parts = new[]
                            {
                                new
                                {
                                    text = content,
                                },
                            },
                        },
                        finishReason = "STOP",
                    },
                },
                usageMetadata = new
                {
                    promptTokenCount = 1,
                    candidatesTokenCount = 1,
                    totalTokenCount = 2,
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
            LastRequestUri = request.RequestUri;
            return Task.FromResult(_responseFactory(request));
        }
    }
}
