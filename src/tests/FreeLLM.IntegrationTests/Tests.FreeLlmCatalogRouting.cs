using System.Net;
using System.Text;
using System.Text.Json;
using FreeLLM;

namespace FreeLLM.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FreeLlmClient_RefreshProviderCatalogsAsync_ReportsMissingAndDiscoveredModels()
    {
        var modelsRequests = 0;
        var chatRequests = 0;
        var handler = new FakeOpenAiChatHandler(request =>
        {
            if (string.Equals(request.Method.Method, HttpMethod.Get.Method, StringComparison.OrdinalIgnoreCase) &&
                request.RequestUri?.AbsolutePath.EndsWith("/models", StringComparison.OrdinalIgnoreCase) == true)
            {
                modelsRequests++;
                return CreateModelsResponse("gpt-5", "gpt-4o-mini");
            }

            chatRequests++;
            return FakeOpenAiChatHandler.JsonResponse(GetRequestedModelId(request));
        });

        using var client = new FreeLlmClientBuilder()
            .AddGitHubModels(
                "test-key",
                provider => provider.WithCatalogRefresh(TimeSpan.FromHours(1), routeDiscoveredModels: true),
                messageHandler: handler)
            .Build();

        var catalogs = await client.RefreshProviderCatalogsAsync();
        var catalog = catalogs.Single(static catalog => catalog.ProviderId == "github-models");

        modelsRequests.Should().Be(1);
        chatRequests.Should().Be(0);
        catalog.MissingConfiguredModelIds.Should().Contain("gpt-4o");
        catalog.Models.Should().Contain(model => model.ModelId == "gpt-4o" && model.IsPresentInLatestCatalog == false);
        catalog.Models.Should().Contain(model =>
            model.ModelId == "gpt-5" &&
            model.IsConfigured == false &&
            model.IsDiscovered &&
            model.IsRoutable &&
            model.Aliases.Contains(FreeLlmModelAliases.Smart));
    }

    [TestMethod]
    public async Task FreeLlmClient_AutoCatalogRefresh_SkipsConfiguredModelsThatDisappear()
    {
        var primaryModelsRequests = 0;
        var primaryChatRequests = 0;
        var primaryHandler = new FakeOpenAiChatHandler(request =>
        {
            if (string.Equals(request.Method.Method, HttpMethod.Get.Method, StringComparison.OrdinalIgnoreCase) &&
                request.RequestUri?.AbsolutePath.EndsWith("/models", StringComparison.OrdinalIgnoreCase) == true)
            {
                primaryModelsRequests++;
                return CreateModelsResponse("available-fast");
            }

            primaryChatRequests++;
            return FakeOpenAiChatHandler.JsonResponse("primary");
        });
        var fallbackChatRequests = 0;
        var fallbackHandler = new FakeOpenAiChatHandler(request =>
        {
            fallbackChatRequests++;
            return FakeOpenAiChatHandler.JsonResponse(GetRequestedModelId(request));
        });

        using var client = new FreeLlmClientBuilder()
            .AddOpenAiCompatible(
                "primary",
                "test-key",
                new Uri("https://example.test/v1/"),
                provider => provider
                    .WithCatalogRefresh(TimeSpan.FromHours(1))
                    .AddModel("missing-smart", model => model.AsSmart(priority: 200))
                    .AddModel("available-fast", model => model.AsFast(priority: 200)),
                messageHandler: primaryHandler)
            .AddOpenAiCompatible(
                "fallback",
                "test-key",
                new Uri("https://example.test/v1/"),
                provider => provider.AddModel("fallback-smart", model => model.AsSmart(priority: 100)),
                messageHandler: fallbackHandler)
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));

        response.Choices[0].Message.Content.Should().Be("fallback-smart");
        primaryModelsRequests.Should().Be(1);
        primaryChatRequests.Should().Be(0);
        fallbackChatRequests.Should().Be(1);

        var primaryCatalog = client.GetProviderCatalogs().Single(static catalog => catalog.ProviderId == "primary");
        primaryCatalog.MissingConfiguredModelIds.Should().Contain("missing-smart");
    }

    [TestMethod]
    public async Task FreeLlmClient_AutoCatalogRefresh_CanRouteDiscoveredModels()
    {
        var modelsRequests = 0;
        var chatRequests = 0;
        var handler = new FakeOpenAiChatHandler(request =>
        {
            if (string.Equals(request.Method.Method, HttpMethod.Get.Method, StringComparison.OrdinalIgnoreCase) &&
                request.RequestUri?.AbsolutePath.EndsWith("/models", StringComparison.OrdinalIgnoreCase) == true)
            {
                modelsRequests++;
                return CreateModelsResponse("gpt-5");
            }

            chatRequests++;
            return FakeOpenAiChatHandler.JsonResponse(GetRequestedModelId(request));
        });

        using var client = new FreeLlmClientBuilder()
            .AddGitHubModels(
                "test-key",
                provider => provider.WithCatalogRefresh(TimeSpan.FromHours(1), routeDiscoveredModels: true),
                messageHandler: handler)
            .Build();

        var response = await client.Chat.CreateChatCompletionAsync(CreateRawRequest(FreeLlmModelAliases.Smart, "hello"));

        response.Choices[0].Message.Content.Should().Be("gpt-5");
        modelsRequests.Should().Be(1);
        chatRequests.Should().Be(1);

        var catalog = client.GetProviderCatalogs().Single(static catalog => catalog.ProviderId == "github-models");
        catalog.Models.Should().Contain(model =>
            model.ModelId == "gpt-5" &&
            model.IsDiscovered &&
            model.IsRoutable);
    }

    private static HttpResponseMessage CreateModelsResponse(params string[] modelIds)
    {
        var payload = JsonSerializer.Serialize(new
        {
            data = modelIds.Select(modelId => new { id = modelId }).ToArray(),
        });

        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(payload, Encoding.UTF8, "application/json"),
        };
    }
}
