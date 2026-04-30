namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static async Task ExecuteProviderAwareAsync(CustomProvider provider, Func<Task> action)
    {
        try
        {
            await action().ConfigureAwait(false);
        }
        catch (ApiException exception)
        {
            RethrowIfKnownProviderAvailabilityIssue(provider, exception);
            throw;
        }
    }

    private static async Task<T> ExecuteProviderAwareAsync<T>(CustomProvider provider, Func<Task<T>> action)
    {
        try
        {
            return await action().ConfigureAwait(false);
        }
        catch (ApiException exception)
        {
            RethrowIfKnownProviderAvailabilityIssue(provider, exception);
            throw;
        }
    }

    private static void RethrowIfKnownProviderAvailabilityIssue(CustomProvider provider, ApiException exception)
    {
        if (provider != CustomProvider.DeepInfra)
        {
            return;
        }

        var responseText = exception.ResponseBody ?? exception.Message;
        if (exception.StatusCode == System.Net.HttpStatusCode.PaymentRequired &&
            responseText.Contains("inference suspended", StringComparison.OrdinalIgnoreCase))
        {
            throw new AssertInconclusiveException(
                "DeepInfra inference is suspended for the configured account. Skipping provider compatibility checks until billing access is restored.",
                exception);
        }
    }

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
        if (customProvider == CustomProvider.Nvidia)
        {
            return (CustomProviders.Nvidia(apiKey:
                Environment.GetEnvironmentVariable("NVIDIA_API_KEY") is { Length: > 0 } nvidiaKeyValue
                ? nvidiaKeyValue
                : throw new AssertInconclusiveException("NVIDIA_API_KEY environment variable is not found.")),
                model ??
                (Environment.GetEnvironmentVariable("NVIDIA_CHAT_MODEL") is { Length: > 0 } nvidiaModel
                    ? nvidiaModel
                    : "meta/llama-3.3-70b-instruct"));
        }
        if (customProvider == CustomProvider.OllamaCloud)
        {
            return (CustomProviders.OllamaCloud(apiKey:
                Environment.GetEnvironmentVariable("OLLAMA_API_KEY") is { Length: > 0 } ollamaCloudKeyValue
                ? ollamaCloudKeyValue
                : throw new AssertInconclusiveException("OLLAMA_API_KEY environment variable is not found.")),
                model ??
                (Environment.GetEnvironmentVariable("OLLAMA_CLOUD_CHAT_MODEL") is { Length: > 0 } ollamaCloudModel
                    ? ollamaCloudModel
                    : "llama3.2"));
        }
        if (customProvider == CustomProvider.Minimax)
        {
            return (CustomProviders.Minimax(apiKey:
                Environment.GetEnvironmentVariable("MINIMAX_API_KEY") is { Length: > 0 } minimaxKeyValue
                ? minimaxKeyValue
                : throw new AssertInconclusiveException("MINIMAX_API_KEY environment variable is not found.")),
                model ??
                (Environment.GetEnvironmentVariable("MINIMAX_CHAT_MODEL") is { Length: > 0 } minimaxModel
                    ? minimaxModel
                    : "MiniMax-M1"));
        }
        if (customProvider == CustomProvider.NousPortal)
        {
            return (CustomProviders.NousPortal(GetRequiredEnvironmentVariable("NOUS_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("NOUS_CHAT_MODEL", "Hermes-4-70B"));
        }
        if (customProvider == CustomProvider.VercelAIGateway)
        {
            return (CustomProviders.VercelAIGateway(GetRequiredEnvironmentVariable("AI_GATEWAY_API_KEY", "VERCEL_AI_GATEWAY_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("AI_GATEWAY_CHAT_MODEL", "xai/grok-4.1-fast-reasoning"));
        }
        if (customProvider == CustomProvider.HuggingFaceRouter)
        {
            return (CustomProviders.HuggingFaceRouter(GetRequiredEnvironmentVariable("HF_TOKEN", "HUGGINGFACE_HUB_TOKEN")),
                model ?? GetOptionalEnvironmentVariable("HF_CHAT_MODEL", "deepseek-ai/DeepSeek-V3-0324"));
        }
        if (customProvider == CustomProvider.GoogleAIStudio)
        {
            return (CustomProviders.GoogleAIStudio(GetRequiredEnvironmentVariable("GEMINI_API_KEY", "GOOGLE_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("GEMINI_CHAT_MODEL", "gemini-2.5-flash"));
        }
        if (customProvider == CustomProvider.XiaomiMiMo)
        {
            return (CustomProviders.XiaomiMiMo(GetRequiredEnvironmentVariable("XIAOMI_API_KEY", "XIAOMI_MIMO_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("XIAOMI_MIMO_CHAT_MODEL", "mimo-v2.5-pro"));
        }
        if (customProvider == CustomProvider.TencentTokenHub)
        {
            return (CustomProviders.TencentTokenHub(GetRequiredEnvironmentVariable("TENCENT_TOKENHUB_API_KEY", "TOKENHUB_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("TENCENT_TOKENHUB_CHAT_MODEL", "hy3-preview"));
        }
        if (customProvider == CustomProvider.TencentTokenHubIntl)
        {
            return (CustomProviders.TencentTokenHubIntl(GetRequiredEnvironmentVariable("TENCENT_TOKENHUB_INTL_API_KEY", "TOKENHUB_INTL_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("TENCENT_TOKENHUB_INTL_CHAT_MODEL", "glm-5"));
        }
        if (customProvider == CustomProvider.ZAi)
        {
            return (CustomProviders.ZAi(GetRequiredEnvironmentVariable("ZAI_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("ZAI_CHAT_MODEL", "glm-4.6"));
        }
        if (customProvider == CustomProvider.Moonshot)
        {
            return (CustomProviders.Moonshot(GetRequiredEnvironmentVariable("MOONSHOT_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("MOONSHOT_CHAT_MODEL", "kimi-k2.5"));
        }
        if (customProvider == CustomProvider.KimiForCoding)
        {
            return (CustomProviders.KimiForCoding(GetRequiredEnvironmentVariable("KIMI_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("KIMI_FOR_CODING_CHAT_MODEL", "kimi-for-coding"));
        }
        if (customProvider == CustomProvider.MoonshotChina)
        {
            return (CustomProviders.MoonshotChina(GetRequiredEnvironmentVariable("MOONSHOT_CN_API_KEY", "MOONSHOT_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("MOONSHOT_CN_CHAT_MODEL", "kimi-k2.6"));
        }
        if (customProvider == CustomProvider.StepFun)
        {
            return (CustomProviders.StepFun(GetRequiredEnvironmentVariable("STEPFUN_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("STEPFUN_CHAT_MODEL", "step-2-mini"));
        }
        if (customProvider == CustomProvider.StepFunStepPlan)
        {
            return (CustomProviders.StepFunStepPlan(GetRequiredEnvironmentVariable("STEPFUN_STEP_PLAN_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("STEPFUN_STEP_PLAN_CHAT_MODEL", "step-3"));
        }
        if (customProvider == CustomProvider.MiniMaxChina)
        {
            return (CustomProviders.MiniMaxChina(GetRequiredEnvironmentVariable("MINIMAX_CN_API_KEY", "MINIMAX_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("MINIMAX_CN_CHAT_MODEL", "MiniMax-M2.7"));
        }
        if (customProvider == CustomProvider.DashScope)
        {
            return (CustomProviders.DashScope(GetRequiredEnvironmentVariable("DASHSCOPE_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("DASHSCOPE_CHAT_MODEL", "qwen-plus"));
        }
        if (customProvider == CustomProvider.DashScopeChina)
        {
            return (CustomProviders.DashScopeChina(GetRequiredEnvironmentVariable("DASHSCOPE_CN_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("DASHSCOPE_CN_CHAT_MODEL", "qwen-plus"));
        }
        if (customProvider == CustomProvider.DashScopeUnitedStates)
        {
            return (CustomProviders.DashScopeUnitedStates(GetRequiredEnvironmentVariable("DASHSCOPE_US_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("DASHSCOPE_US_CHAT_MODEL", "qwen-plus-us"));
        }
        if (customProvider == CustomProvider.DashScopeCodingPlan)
        {
            return (CustomProviders.DashScopeCodingPlan(GetRequiredEnvironmentVariable("DASHSCOPE_CODING_PLAN_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("DASHSCOPE_CODING_PLAN_CHAT_MODEL", "qwen3-coder-plus"));
        }
        if (customProvider == CustomProvider.ArceeAI)
        {
            return (CustomProviders.ArceeAI(GetRequiredEnvironmentVariable("ARCEE_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("ARCEE_CHAT_MODEL", "trinity-mini"));
        }
        if (customProvider == CustomProvider.ArceeConductor)
        {
            return (CustomProviders.ArceeConductor(GetRequiredEnvironmentVariable("ARCEE_CONDUCTOR_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("ARCEE_CONDUCTOR_CHAT_MODEL", "auto"));
        }
        if (customProvider == CustomProvider.GmiCloud)
        {
            return (CustomProviders.GmiCloud(GetRequiredEnvironmentVariable("GMI_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("GMI_CHAT_MODEL", "deepseek-ai/DeepSeek-R1"));
        }
        if (customProvider == CustomProvider.KiloGateway)
        {
            return (CustomProviders.KiloGateway(GetRequiredEnvironmentVariable("KILO_API_KEY", "KILOCODE_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("KILO_CHAT_MODEL", "kilocode/kilo/auto"));
        }
        if (customProvider == CustomProvider.OpenCodeZen)
        {
            return (CustomProviders.OpenCodeZen(GetRequiredEnvironmentVariable("OPENCODE_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("OPENCODE_ZEN_CHAT_MODEL", "qwen3.5-plus"));
        }
        if (customProvider == CustomProvider.OpenCodeGo)
        {
            return (CustomProviders.OpenCodeGo(GetRequiredEnvironmentVariable("OPENCODE_API_KEY")),
                model ?? GetOptionalEnvironmentVariable("OPENCODE_GO_CHAT_MODEL", "kimi-k2.6"));
        }

        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") is { Length: > 0 } openAiKeyValue
            ? openAiKeyValue
            : throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var api = new OpenAiClient(apiKey);

        return (api, model ?? ModelIdsSharedEnum.Gpt4oMini.ToValueString());
    }

    private static string GetRequiredEnvironmentVariable(params string[] names)
    {
        foreach (var name in names)
        {
            if (Environment.GetEnvironmentVariable(name) is { Length: > 0 } value)
            {
                return value;
            }
        }

        throw new AssertInconclusiveException($"{string.Join(" or ", names)} environment variable is not found.");
    }

    private static string GetOptionalEnvironmentVariable(string name, string defaultValue)
    {
        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? value
            : defaultValue;
    }
}
