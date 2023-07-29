namespace tryAGI.OpenAI;

// ReSharper disable InconsistentNaming
#pragma warning disable CA1707

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
    /// More capable than any GPT-3.5 model, able to do more complex tasks, and optimized for chat. <br/>
    /// Will be updated with our latest model iteration 2 weeks after it is released. <br/>
    /// Max tokens: 8,192 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// <remarks>On June 27th, 2023, gpt-4 will be updated to point from gpt-4-0314 to gpt-4-0613, the latest model iteration.</remarks>
    /// </summary>
    public const string Ada002 = "text-embedding-ada-002";
}