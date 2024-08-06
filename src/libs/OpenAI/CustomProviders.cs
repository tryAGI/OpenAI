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
    public const string DeepInfraBaseUrl = "https://api.deepinfra.com/";
    
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
    /// Creates an API to use for GitHub Models: https://github.com/marketplace/models
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi GitHubModels(string githubToken)
    {
        var api = new OpenAiApi(baseUri: new Uri(GitHubModelsBaseUrl));
        api.AuthorizeUsingBearer(githubToken);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for Azure.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Azure(string apiKey, string endpoint)
    {
        var api = new OpenAiApi(baseUri: new Uri(endpoint));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for DeepInfra.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi DeepInfra(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri(DeepInfraBaseUrl));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for DeepSeek.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi DeepSeek(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri(DeepSeekBaseUrl));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for Fireworks AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Fireworks(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri(FireworksBaseUrl));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for Open Router.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi OpenRouter(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri(OpenRouterBaseUrl));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for Together AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Together(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri(TogetherBaseUrl));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
}