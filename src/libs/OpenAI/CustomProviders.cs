// ReSharper disable once CheckNamespace
namespace OpenAI;

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
    /// Creates an API to use for GitHub Models: https://github.com/marketplace/models
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi GitHubModels(string githubToken)
    {
        return new OpenAiApi(githubToken, baseUri: new Uri(GitHubModelsBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Azure.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Azure(string apiKey, string endpoint)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(endpoint));
    }
    
    /// <summary>
    /// Create an API to use for DeepInfra.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi DeepInfra(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(DeepInfraBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for DeepSeek.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi DeepSeek(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(DeepSeekBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Fireworks AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Fireworks(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(FireworksBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Open Router.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi OpenRouter(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(OpenRouterBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Together AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Together(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(TogetherBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Perplexity AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Perplexity(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(PerplexityBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for SambaNova AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi SambaNova(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(SambaNovaBaseUrl));
    }
}