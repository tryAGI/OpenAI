// ReSharper disable once CheckNamespace
namespace tryAGI.OpenAI;

/// <summary>
/// Predefined providers uses OpenAI SDK compatible API.
/// </summary>
public static class CustomProviders
{
    /// <summary>
    /// https://github.com/marketplace/models
    /// </summary>
    public const string GitHubModelsBaseUrl = "https://models.inference.ai.azure.com/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string DeepInfraBaseUrl = "https://api.deepinfra.com/v1/openai";
    
    /// <summary>
    /// 
    /// </summary>
    public const string GroqBaseUrl = "https://api.groq.com/openai/v1/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string XAiBaseUrl = "https://api.x.ai/v1/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string DeepSeekBaseUrl = "https://api.deepseek.com/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string FireworksBaseUrl = "https://api.fireworks.ai/inference/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string OpenRouterBaseUrl = "https://openrouter.ai/api/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string TogetherBaseUrl = "https://api.together.xyz/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string PerplexityBaseUrl = "https://api.perplexity.ai/";
    
    /// <summary>
    /// 
    /// </summary>
    public const string SambaNovaBaseUrl = "https://api.sambanova.ai/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string MistralBaseUrl = "https://api.mistral.ai/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string CodestralBaseUrl = "https://codestral.mistral.ai/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string HyperbolicBaseUrl = "https://api.hyperbolic.xyz/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string CohereBaseUrl = "https://api.cohere.ai/compatibility/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string OllamaBaseUrl = "http://localhost:11434/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string LmStudioBaseUrl = "http://localhost:1234/v1";

    /// <summary>
    /// https://inference-docs.cerebras.ai/openai
    /// </summary>
    public const string CerebrasBaseUrl = "https://api.cerebras.ai/v1";

    /// <summary>
    /// Creates an API to use for GitHub Models: https://github.com/marketplace/models
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient GitHubModels(string githubToken)
    {
        return new OpenAiClient(githubToken, baseUri: new Uri(GitHubModelsBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Azure.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Azure(string apiKey, string endpoint)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(endpoint));
    }
    
    /// <summary>
    /// Create an API to use for DeepInfra.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient DeepInfra(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(DeepInfraBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Groq.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Groq(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(GroqBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for xAI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient XAi(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(XAiBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for DeepSeek.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient DeepSeek(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(DeepSeekBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Fireworks AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Fireworks(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(FireworksBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Open Router.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient OpenRouter(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(OpenRouterBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Together AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Together(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(TogetherBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Perplexity AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Perplexity(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(PerplexityBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for SambaNova AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient SambaNova(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(SambaNovaBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Mistral.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Mistral(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(MistralBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Codestral.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Codestral(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(CodestralBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Hyperbolic.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Hyperbolic(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(HyperbolicBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Cohere.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Cohere(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(CohereBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Ollama.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Ollama(Uri? baseUri = null)
    {
        return new OpenAiClient(baseUri: baseUri ?? new Uri(OllamaBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for LM Studio.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient LmStudio(Uri? baseUri = null)
    {
        return new OpenAiClient(baseUri: baseUri ?? new Uri(LmStudioBaseUrl));
    }

    /// <summary>
    /// Create an API to use for Cerebras.
    /// </summary>
    /// <returns></returns>
    public static OpenAiClient Cerebras(string apiKey)
    {
        return new OpenAiClient(apiKey, baseUri: new Uri(CerebrasBaseUrl));
    }
}