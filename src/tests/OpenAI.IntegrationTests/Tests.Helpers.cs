namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OpenAiClient GetAuthenticatedClient() => GetAuthorizedApi();

    private static OpenAiClient GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } apiKeyValue
            ? apiKeyValue
            : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var client = new OpenAiClient(apiKey);

        return client;
    }
    
    private static RealtimeConversationClient GetAuthenticatedRealtimeClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } realtimeKeyValue
            ? realtimeKeyValue
            : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

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

        if (customProvider == CustomProvider.Azure)
        {
            var azureKey = Environment.GetEnvironmentVariable("AZURE_OPENAI_API_KEY") is { Length: > 0 } azureKeyValue
                ? azureKeyValue
                : throw new AssertInconclusiveException("AZURE_OPENAI_API_KEY environment variable is not found.");
            var endpoint = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT") is { Length: > 0 } endpointValue
                ? endpointValue
                : throw new AssertInconclusiveException("AZURE_OPENAI_ENDPOINT environment variable is not found.");
            return (CustomProviders.Azure(azureKey, endpoint),
                model ??
                (Environment.GetEnvironmentVariable("AZURE_OPENAI_MODEL") is { Length: > 0 } azureModel
                    ? azureModel
                    : "gpt-4o-mini"));
        }
        if (customProvider == CustomProvider.Fireworks)
        {
            return (CustomProviders.Fireworks(apiKey:
                Environment.GetEnvironmentVariable("FIREWORKS_API_KEY") is { Length: > 0 } fireworksKeyValue
                ? fireworksKeyValue
                : throw new AssertInconclusiveException("FIREWORKS_API_KEY environment variable is not found.")),
                model ?? "accounts/fireworks/models/llama-v3p3-70b-instruct");
        }
        if (customProvider == CustomProvider.DeepInfra)
        {
            return (CustomProviders.DeepInfra(apiKey:
                Environment.GetEnvironmentVariable("DEEPINFRA_API_KEY") is { Length: > 0 } deepInfraKeyValue
                ? deepInfraKeyValue
                : throw new AssertInconclusiveException("DEEPINFRA_API_KEY environment variable is not found.")),
                model ?? "Qwen/Qwen2.5-72B-Instruct");
        }
        if (customProvider == CustomProvider.Groq)
        {
            return (CustomProviders.Groq(apiKey:
                    Environment.GetEnvironmentVariable("GROQ_API_KEY") is { Length: > 0 } groqKeyValue
                    ? groqKeyValue
                    : throw new AssertInconclusiveException("GROQ_API_KEY environment variable is not found.")),
                model ??
                (Environment.GetEnvironmentVariable("GROQ_CHAT_MODEL") is { Length: > 0 } groqModel
                    ? groqModel
                    : "llama-3.3-70b-versatile"));
        }
        if (customProvider == CustomProvider.DeepSeek)
        {
            return (CustomProviders.DeepSeek(apiKey:
                Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY") is { Length: > 0 } deepSeekKeyValue
                ? deepSeekKeyValue
                : throw new AssertInconclusiveException("DEEPSEEK_API_KEY environment variable is not found.")),
                model ?? "deepseek-chat");
        }
        if (customProvider == CustomProvider.OpenRouter)
        {
            return (CustomProviders.OpenRouter(apiKey:
                Environment.GetEnvironmentVariable("OPENROUTER_API_KEY") is { Length: > 0 } openRouterKeyValue
                ? openRouterKeyValue
                : throw new AssertInconclusiveException("OPENROUTER_API_KEY environment variable is not found.")),
                model ?? "meta-llama/llama-3.2-3b-instruct:free");
        }
        if (customProvider == CustomProvider.Together)
        {
            return (CustomProviders.Together(apiKey:
                Environment.GetEnvironmentVariable("TOGETHER_API_KEY") is { Length: > 0 } togetherKeyValue
                ? togetherKeyValue
                : throw new AssertInconclusiveException("TOGETHER_API_KEY environment variable is not found.")),
                model ??
                (Environment.GetEnvironmentVariable("TOGETHER_CHAT_MODEL") is { Length: > 0 } togetherModel
                    ? togetherModel
                    : "meta-llama/Llama-3.3-70B-Instruct-Turbo"));
        }
        if (customProvider == CustomProvider.GitHub)
        {
            return (CustomProviders.GitHubModels(githubToken:
                Environment.GetEnvironmentVariable("TOKEN_FOR_GITHUB_MODELS") is { Length: > 0 } githubTokenValue
                ? githubTokenValue
                : throw new AssertInconclusiveException("TOKEN_FOR_GITHUB_MODELS environment variable is not found.")),
                model ?? "gpt-4o");
        }
        if (customProvider == CustomProvider.Perplexity)
        {
            return (CustomProviders.Perplexity(apiKey:
                    Environment.GetEnvironmentVariable("PERPLEXITY_API_KEY") is { Length: > 0 } perplexityKeyValue
                    ? perplexityKeyValue
                    : throw new AssertInconclusiveException("PERPLEXITY_API_KEY environment variable is not found.")),
                model ?? "sonar");
        }
        if (customProvider == CustomProvider.SambaNova)
        {
            return (CustomProviders.SambaNova(apiKey:
                    Environment.GetEnvironmentVariable("SAMBANOVA_API_KEY") is { Length: > 0 } sambaNovaKeyValue
                    ? sambaNovaKeyValue
                    : throw new AssertInconclusiveException("SAMBANOVA_API_KEY environment variable is not found.")),
                model ?? "Meta-Llama-3.3-70B-Instruct");
        }
        if (customProvider == CustomProvider.Mistral)
        {
            return (CustomProviders.Mistral(apiKey:
                    Environment.GetEnvironmentVariable("MISTRAL_API_KEY") is { Length: > 0 } mistralKeyValue
                    ? mistralKeyValue
                    : throw new AssertInconclusiveException("MISTRAL_API_KEY environment variable is not found.")),
                model ?? "mistral-large-latest");
        }
        if (customProvider == CustomProvider.Codestral)
        {
            return (CustomProviders.Codestral(apiKey:
                    Environment.GetEnvironmentVariable("CODESTRAL_API_KEY") is { Length: > 0 } codestralKeyValue
                    ? codestralKeyValue
                    : throw new AssertInconclusiveException("CODESTRAL_API_KEY environment variable is not found.")),
                model ?? "codestral-latest");
        }
        if (customProvider == CustomProvider.Hyperbolic)
        {
            return (CustomProviders.Hyperbolic(apiKey:
                    Environment.GetEnvironmentVariable("HYPERBOLIC_API_KEY") is { Length: > 0 } hyperbolicKeyValue
                    ? hyperbolicKeyValue
                    : throw new AssertInconclusiveException("HYPERBOLIC_API_KEY environment variable is not found.")),
                model ??
                (Environment.GetEnvironmentVariable("HYPERBOLIC_CHAT_MODEL") is { Length: > 0 } hyperbolicModel
                    ? hyperbolicModel
                    : "meta-llama/Llama-3.3-70B-Instruct"));
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
                Environment.GetEnvironmentVariable("CEREBRAS_API_KEY") is { Length: > 0 } cerebrasKeyValue
                ? cerebrasKeyValue
                : throw new AssertInconclusiveException("CEREBRAS_API_KEY environment variable is not found.")),
                model ?? "llama3.1-70b");
        }
        if (customProvider == CustomProvider.XAi)
        {
            return (CustomProviders.XAi(apiKey:
                Environment.GetEnvironmentVariable("XAI_API_KEY") is { Length: > 0 } xAiKeyValue
                ? xAiKeyValue
                : throw new AssertInconclusiveException("XAI_API_KEY environment variable is not found.")),
                model ??
                (Environment.GetEnvironmentVariable("XAI_CHAT_MODEL") is { Length: > 0 } xAiModel
                    ? xAiModel
                    : "grok-3-mini"));
        }
        if (customProvider == CustomProvider.Cohere)
        {
            return (CustomProviders.Cohere(apiKey:
                Environment.GetEnvironmentVariable("COHERE_API_KEY") is { Length: > 0 } cohereKeyValue
                ? cohereKeyValue
                : throw new AssertInconclusiveException("COHERE_API_KEY environment variable is not found.")),
                model ?? "command-r-08-2024");
        }
        if (customProvider == CustomProvider.Nebius)
        {
            return (CustomProviders.Nebius(apiKey:
                Environment.GetEnvironmentVariable("NEBIUS_API_KEY") is { Length: > 0 } nebiusKeyValue
                ? nebiusKeyValue
                : throw new AssertInconclusiveException("NEBIUS_API_KEY environment variable is not found.")),
                model ?? "Qwen/Qwen2.5-72B-Instruct");
        }

        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } openAiKeyValue
            ? openAiKeyValue
            : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var api = new OpenAiClient(apiKey);

        return (api, model ?? ModelIdsSharedEnum.Gpt4oMini.ToValueString());
    }
}
