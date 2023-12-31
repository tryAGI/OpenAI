namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming
#pragma warning disable CA1707

/// <summary>
/// According https://platform.openai.com/docs/guides/embeddings/embedding-models
/// <remarks>
/// OpenAI offers one second-generation embedding model (denoted by -002 in the model ID) and 16 first-generation models (denoted by -001 in the model ID).
/// We recommend using text-embedding-ada-002 for nearly all use cases. It’s better, cheaper, and simpler to use. Read the blog post announcement.
/// </remarks>
/// </summary>
public readonly record struct EmbeddingModel(string Value)
{
    /// <summary>
    /// We recommend using text-embedding-ada-002 for nearly all use cases. It’s better, cheaper, and simpler to use. <br/>
    /// Max input tokens: 8,191 tokens <br/>
    /// Output dimensions: 1536 <br/>
    /// </summary>
    internal const string Ada002Value = "text-embedding-ada-002";
    
    /// <inheritdoc cref="Ada002Value"/>
    public static EmbeddingModel Ada002 { get; } = new(Ada002Value);

    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="EmbeddingModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(EmbeddingModel model)
    {
        return model.Value;
    }
}