namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TogetherProvider_UsesOpenAiCompatibleV1BaseUrl()
    {
        using var api = CustomProviders.Together("test-api-key");

        api.BaseUri.Should().Be(new Uri(CustomProviders.TogetherBaseUrl));
    }

    [TestMethod]
    public void TogetherProvider_AllowsModelOverrideFromEnvironment()
    {
        const string apiKeyVariable = "TOGETHER_API_KEY";
        const string modelVariable = "TOGETHER_CHAT_MODEL";

        var originalApiKey = Environment.GetEnvironmentVariable(apiKeyVariable);
        var originalModel = Environment.GetEnvironmentVariable(modelVariable);

        try
        {
            Environment.SetEnvironmentVariable(apiKeyVariable, "test-api-key");
            Environment.SetEnvironmentVariable(modelVariable, "test-chat-model");

            var pair = GetAuthorizedChatApi(CustomProvider.Together);
            using var api = pair.Api;

            pair.Model.Should().Be("test-chat-model");
            api.BaseUri.Should().Be(new Uri(CustomProviders.TogetherBaseUrl));
        }
        finally
        {
            Environment.SetEnvironmentVariable(apiKeyVariable, originalApiKey);
            Environment.SetEnvironmentVariable(modelVariable, originalModel);
        }
    }

    [TestMethod]
    public void AdditionalProviderFactories_UseDocumentedBaseUrls()
    {
        AssertBaseUri(CustomProviders.NousPortal("test-api-key"), CustomProviders.NousPortalBaseUrl);
        AssertBaseUri(CustomProviders.VercelAIGateway("test-api-key"), CustomProviders.VercelAIGatewayBaseUrl);
        AssertBaseUri(CustomProviders.HuggingFaceRouter("test-api-key"), CustomProviders.HuggingFaceRouterBaseUrl);
        AssertBaseUri(CustomProviders.GoogleAIStudio("test-api-key"), CustomProviders.GoogleAIStudioBaseUrl);
        AssertBaseUri(CustomProviders.Gemini("test-api-key"), CustomProviders.GoogleAIStudioBaseUrl);
        AssertBaseUri(CustomProviders.XiaomiMiMo("test-api-key"), CustomProviders.XiaomiMiMoBaseUrl);
        AssertBaseUri(CustomProviders.TencentTokenHub("test-api-key"), CustomProviders.TencentTokenHubBaseUrl);
        AssertBaseUri(CustomProviders.TencentTokenHubIntl("test-api-key"), CustomProviders.TencentTokenHubIntlBaseUrl);
        AssertBaseUri(CustomProviders.ZAi("test-api-key"), CustomProviders.ZAiBaseUrl);
        AssertBaseUri(CustomProviders.Moonshot("test-api-key"), CustomProviders.MoonshotBaseUrl);
        AssertBaseUri(CustomProviders.KimiForCoding("test-api-key"), CustomProviders.KimiForCodingBaseUrl);
        AssertBaseUri(CustomProviders.MoonshotChina("test-api-key"), CustomProviders.MoonshotChinaBaseUrl);
        AssertBaseUri(CustomProviders.StepFun("test-api-key"), CustomProviders.StepFunBaseUrl);
        AssertBaseUri(CustomProviders.StepFunStepPlan("test-api-key"), CustomProviders.StepFunStepPlanBaseUrl);
        AssertBaseUri(CustomProviders.MiniMaxChina("test-api-key"), CustomProviders.MiniMaxChinaBaseUrl);
        AssertBaseUri(CustomProviders.DashScope("test-api-key"), CustomProviders.DashScopeBaseUrl);
        AssertBaseUri(CustomProviders.DashScopeChina("test-api-key"), CustomProviders.DashScopeChinaBaseUrl);
        AssertBaseUri(CustomProviders.DashScopeUnitedStates("test-api-key"), CustomProviders.DashScopeUnitedStatesBaseUrl);
        AssertBaseUri(CustomProviders.DashScopeCodingPlan("test-api-key"), CustomProviders.DashScopeCodingPlanBaseUrl);
        AssertBaseUri(CustomProviders.ArceeAI("test-api-key"), CustomProviders.ArceeAIBaseUrl);
        AssertBaseUri(CustomProviders.ArceeConductor("test-api-key"), CustomProviders.ArceeConductorBaseUrl);
        AssertBaseUri(CustomProviders.GmiCloud("test-api-key"), CustomProviders.GmiCloudBaseUrl);
        AssertBaseUri(CustomProviders.KiloGateway("test-api-key"), CustomProviders.KiloGatewayBaseUrl);
        AssertBaseUri(CustomProviders.OpenCodeZen("test-api-key"), CustomProviders.OpenCodeZenBaseUrl);
        AssertBaseUri(CustomProviders.OpenCodeGo("test-api-key"), CustomProviders.OpenCodeGoBaseUrl);
    }

    private static void AssertBaseUri(OpenAiClient api, string baseUrl)
    {
        using (api)
        {
            api.BaseUri.Should().Be(new Uri(baseUrl));
        }
    }
}
