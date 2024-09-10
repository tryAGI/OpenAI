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
    
    internal static (OpenAiApi Api, string Model) GetAuthorizedChatApi(CustomProvider customProvider, string? model = null)
    {
        if (customProvider == CustomProvider.Fireworks)
        {
            return (CustomProviders.Fireworks(apiKey:
                Environment.GetEnvironmentVariable("FIREWORKS_API_KEY") ??
                throw new AssertInconclusiveException("FIREWORKS_API_KEY environment variable is not found.")),
                model ?? "accounts/fireworks/models/llama-v3p1-8b-instruct");
        }
        if (customProvider == CustomProvider.DeepInfra)
        {
            return (CustomProviders.DeepInfra(apiKey:
                Environment.GetEnvironmentVariable("DEEPINFRA_API_KEY") ??
                throw new AssertInconclusiveException("DEEPINFRA_API_KEY environment variable is not found.")),
                model ?? "meta-llama/Meta-Llama-3.1-8B-Instruct");
        }
        if (customProvider == CustomProvider.DeepSeek)
        {
            return (CustomProviders.DeepSeek(apiKey:
                Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY") ??
                throw new AssertInconclusiveException("DEEPSEEK_API_KEY environment variable is not found.")),
                model ?? "deepseek-chat");
        }
        if (customProvider == CustomProvider.OpenRouter)
        {
            return (CustomProviders.OpenRouter(apiKey:
                Environment.GetEnvironmentVariable("OPENROUTER_API_KEY") ??
                throw new AssertInconclusiveException("OPENROUTER_API_KEY environment variable is not found.")),
                model ?? "meta-llama/llama-3.1-8b-instruct:free");
        }
        if (customProvider == CustomProvider.Together)
        {
            return (CustomProviders.Together(apiKey:
                Environment.GetEnvironmentVariable("TOGETHER_API_KEY") ??
                throw new AssertInconclusiveException("TOGETHER_API_KEY environment variable is not found.")),
                model ?? "meta-llama/Meta-Llama-3.1-8B-Instruct-Turbo");
        }
        if (customProvider == CustomProvider.GitHub)
        {
            return (CustomProviders.GitHubModels(githubToken:
                Environment.GetEnvironmentVariable("TOKEN_FOR_GITHUB_MODELS") ??
                throw new AssertInconclusiveException("TOKEN_FOR_GITHUB_MODELS environment variable is not found.")),
                model ?? "gpt-4o");
        }
        if (customProvider == CustomProvider.Perplexity)
        {
            return (CustomProviders.Perplexity(apiKey:
                    Environment.GetEnvironmentVariable("PERPLEXITY_API_KEY") ??
                    throw new AssertInconclusiveException("PERPLEXITY_API_KEY environment variable is not found.")),
                model ?? "llama-3.1-sonar-small-128k-online");
        }
        
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var api = new OpenAiApi(apiKey);

        return (api, model ?? ChatClient.LatestFastModel.ToValueString());
    }
}
