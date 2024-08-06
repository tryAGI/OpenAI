namespace OpenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OpenAiApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var client = new OpenAiApi();
        client.AuthorizeUsingBearer(apiKey);

        return client;
    }
    
    private static (OpenAiApi Api, string Model) GetAuthorizedChatApi(CustomProvider customProvider)
    {
        if (customProvider == CustomProvider.Fireworks)
        {
            return (CustomProviders.Fireworks(apiKey:
                Environment.GetEnvironmentVariable("FIREWORKS_API_KEY") ??
                throw new AssertInconclusiveException("FIREWORKS_API_KEY environment variable is not found.")),
                "accounts/fireworks/models/llama-v3p1-8b-instruct");
        }
        if (customProvider == CustomProvider.DeepInfra)
        {
            return (CustomProviders.DeepInfra(apiKey:
                Environment.GetEnvironmentVariable("DEEPINFRA_API_KEY") ??
                throw new AssertInconclusiveException("DEEPINFRA_API_KEY environment variable is not found.")),
                "meta-llama/Meta-Llama-3.1-8B-Instruct");
        }
        if (customProvider == CustomProvider.DeepSeek)
        {
            return (CustomProviders.DeepSeek(apiKey:
                Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY") ??
                throw new AssertInconclusiveException("DEEPSEEK_API_KEY environment variable is not found.")),
                "deepseek-chat");
        }
        if (customProvider == CustomProvider.OpenRouter)
        {
            return (CustomProviders.OpenRouter(apiKey:
                Environment.GetEnvironmentVariable("OPENROUTER_API_KEY") ??
                throw new AssertInconclusiveException("OPENROUTER_API_KEY environment variable is not found.")),
                "meta-llama/llama-3.1-8b-instruct:free");
        }
        if (customProvider == CustomProvider.Together)
        {
            return (CustomProviders.Together(apiKey:
                Environment.GetEnvironmentVariable("TOGETHER_API_KEY") ??
                throw new AssertInconclusiveException("TOGETHER_API_KEY environment variable is not found.")),
                "meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo");
        }
        
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var api = new OpenAiApi(apiKey);

        return (api, ChatClient.LatestFastModel.ToValueString());
    }
}
