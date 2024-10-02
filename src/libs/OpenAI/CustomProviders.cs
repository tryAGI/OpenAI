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
    public const string GroqBaseUrl = "https://api.groq.com/openai/v1/";
    
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
    public const string OllamaBaseUrl = "http://localhost:11434/v1";
    
    /// <summary>
    /// 
    /// </summary>
    public const string LmStudioBaseUrl = "http://localhost:1234/v1";
    
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
    /// Create an API to use for Groq.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Groq(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(GroqBaseUrl));
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
    
    /// <summary>
    /// Create an API to use for Mistral.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Mistral(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(MistralBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Codestral.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Codestral(string apiKey)
    {
        return new OpenAiApi(apiKey, baseUri: new Uri(CodestralBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for Ollama.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi Ollama(Uri? baseUri = null)
    {
        return new OpenAiApi(baseUri: baseUri ?? new Uri(OllamaBaseUrl));
    }
    
    /// <summary>
    /// Create an API to use for LM Studio.
    /// </summary>
    /// <returns></returns>
    public static OpenAiApi LmStudio(Uri? baseUri = null)
    {
        return new OpenAiApi(baseUri: baseUri ?? new Uri(LmStudioBaseUrl));
    }
}