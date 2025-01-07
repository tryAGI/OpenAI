namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OpenAiClient GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var client = new OpenAiClient(apiKey);

        return client;
    }
    
    private static RealtimeConversationClient GetAuthenticatedRealtimeClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var client = new RealtimeConversationClient(apiKey);

        return client;
    }
    
    internal static (OpenAiClient Api, string Model) GetAuthorizedChatApi(CustomProvider customProvider, string? model = null)
    {
        const string localIpAddress = "10.10.5.85";
        if (customProvider is CustomProvider.Ollama or CustomProvider.LmStudio)// &&
            //Environment.GetEnvironmentVariable("LOCAL_TESTS") is null)
        {
            throw new AssertInconclusiveException("This test only runs on local environment.");
        }

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
        if (customProvider == CustomProvider.Groq)
        {
            return (CustomProviders.Groq(apiKey:
                    Environment.GetEnvironmentVariable("GROQ_API_KEY") ??
                    throw new AssertInconclusiveException("GROQ_API_KEY environment variable is not found.")),
                model ?? "llama3-8b-8192");
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
        if (customProvider == CustomProvider.SambaNova)
        {
            return (CustomProviders.SambaNova(apiKey:
                    Environment.GetEnvironmentVariable("SAMBANOVA_API_KEY") ??
                    throw new AssertInconclusiveException("SAMBANOVA_API_KEY environment variable is not found.")),
                model ?? "Meta-Llama-3.1-8B-Instruct");
        }
        if (customProvider == CustomProvider.Mistral)
        {
            return (CustomProviders.Mistral(apiKey:
                    Environment.GetEnvironmentVariable("MISTRAL_API_KEY") ??
                    throw new AssertInconclusiveException("MISTRAL_API_KEY environment variable is not found.")),
                model ?? "mistral-large-latest");
        }
        if (customProvider == CustomProvider.Codestral)
        {
            return (CustomProviders.Codestral(apiKey:
                    Environment.GetEnvironmentVariable("CODESTRAL_API_KEY") ??
                    throw new AssertInconclusiveException("CODESTRAL_API_KEY environment variable is not found.")),
                model ?? "codestral-latest");
        }
        if (customProvider == CustomProvider.Hyperbolic)
        {
            return (CustomProviders.Hyperbolic(apiKey:
                    Environment.GetEnvironmentVariable("HYPERBOLIC_API_KEY") ??
                    throw new AssertInconclusiveException("HYPERBOLIC_API_KEY environment variable is not found.")),
                model ?? "meta-llama/Llama-3.2-3B-Instruct");
        }

        if (customProvider == CustomProvider.Ollama)
        {
            var pair = (CustomProviders.Ollama(new Uri($"http://{localIpAddress}:11434/v1")),
                model ?? "llama3.2");
            //pair.Item1.HttpClient.Timeout = TimeSpan.FromSeconds(15);
            
            return pair;
        }
        if (customProvider == CustomProvider.LmStudio)
        {
            var pair = (CustomProviders.LmStudio(new Uri($"http://{localIpAddress}:1234/v1")),
                model ?? "lmstudio-community/Llama-3.2-3B-Instruct-GGUF");
            //pair.Item1.HttpClient.Timeout = TimeSpan.FromSeconds(15);
            
            return pair;
        }
        if (customProvider == CustomProvider.Cerebras)
        {
            return (CustomProviders.Cerebras(apiKey:
                Environment.GetEnvironmentVariable("CEREBRAS_API_KEY") ??
                throw new AssertInconclusiveException("CEREBRAS_API_KEY environment variable is not found.")),
                model ?? "llama3.1-70b");
        }
        if (customProvider == CustomProvider.XAi)
        {
            return (CustomProviders.XAi(apiKey:
                Environment.GetEnvironmentVariable("XAI_API_KEY") ??
                throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.")),
                model ?? "grok-beta");
        }

        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var api = new OpenAiClient(apiKey);

        return (api, model ?? ChatClient.LatestFastModel.ToValueString());
    }
}
