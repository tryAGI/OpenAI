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
}
