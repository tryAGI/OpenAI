namespace tryAGI.OpenAI;

/// <summary>
/// According https://platform.openai.com/docs/guides/embeddings/embedding-models
/// <remarks>
/// OpenAI offers one second-generation embedding model (denoted by -002 in the model ID) and 16 first-generation models (denoted by -001 in the model ID).
/// We recommend using text-embedding-ada-002 for nearly all use cases. It’s better, cheaper, and simpler to use. Read the blog post announcement.
/// </remarks>
/// </summary>
public static class EmbeddingModelIds
{ 
    /// <summary>
    /// We recommend using text-embedding-ada-002 for nearly all use cases. It’s better, cheaper, and simpler to use. <br/>
    /// Max input tokens: 8,191 tokens <br/>
    /// Output dimensions: 1536 <br/>
    /// </summary>
    public const string Ada002 = "text-embedding-ada-002";
}