// ReSharper disable once CheckNamespace
namespace OpenAI;

/// <summary>
/// Predefined providers uses OpenAI SDK compatible API.
/// </summary>
public static class Providers
{
    /// <summary>
    /// Create an API to use for GitHub Models: https://github.com/marketplace/models
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi GitHubModels(string githubToken)
    {
        var api = new OpenAiApi(baseUri: new Uri("https://models.inference.ai.azure.com/"));
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
        var api = new OpenAiApi(baseUri: new Uri("https://api.deepinfra.com/"));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for DeepSeek.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi DeepSeek(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri("https://api.deepseek.com/"));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for Fireworks AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Fireworks(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri("https://api.fireworks.ai/inference/v1"));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for Open Router.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi OpenRouter(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri("https://openrouter.ai/api"));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
    
    /// <summary>
    /// Create an API to use for Together AI.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Together(string apiKey)
    {
        var api = new OpenAiApi(baseUri: new Uri("https://api.together.xyz/"));
        api.AuthorizeUsingBearer(apiKey);
        
        return api;
    }
}