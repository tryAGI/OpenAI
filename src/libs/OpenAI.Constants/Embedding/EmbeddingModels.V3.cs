// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According: <br/>
/// - https://platform.openai.com/docs/guides/embeddings/embedding-models <br/>
/// - https://openai.com/blog/new-embedding-models-and-api-updates <br/>
/// <remarks>
/// <see cref="Version3Small"/> and <see cref="Version3Large"/>, our newest and
/// most performant embedding models are now available, with lower costs,
/// higher multilingual performance, and new parameters to control the overall size.
/// </remarks>
/// </summary>
public readonly partial record struct EmbeddingModels
{
    /// <summary>
    /// <see cref="Version3Small"/> is our new highly efficient embedding model
    /// and provides a significant upgrade over its predecessor,
    /// the <see cref="Ada002"/> model released in December 2022.  <br/>
    /// Max input tokens: 8,191 tokens <br/>
    /// Tokenizer: cl100k_base <br/>
    /// Max and default output dimensions: 1536 <br/>
    /// Rough pages per dollar: 62,500 <br/>
    /// MIRACL average(1536): 44.0% <br/>
    /// MTEB average(512): 61.6% <br/>
    /// MTEB average(1536): 62.3% <br/>
    /// </summary>
    internal const string Version3SmallId = "text-embedding-3-small";
    
    /// <summary>
    /// <see cref="Version3Large"/> is our new next generation larger embedding model
    /// and creates embeddings with up to 3072 dimensions. <br/>
    /// Max input tokens: 8,191 tokens <br/>
    /// Tokenizer: cl100k_base <br/>
    /// Max and default output dimensions: 3072 <br/>
    /// Rough pages per dollar: 9,615 <br/>
    /// MIRACL average(3072): 54.9% <br/>
    /// MTEB average(256): 62.0% <br/>
    /// MTEB average(1024): 64.1% <br/>
    /// MTEB average(3072): 64.6% <br/>
    /// </summary>
    internal const string Version3LargeId = "text-embedding-3-large";
    
    /// <inheritdoc cref="Version3SmallId"/>
    public static EmbeddingModels Version3Small { get; } = new(
        Id: Version3SmallId,
        MaxInputTokens: 8_191,
        PricePerTokenInUsd: 0.00002 * 0.001);
    
    /// <inheritdoc cref="Version3LargeId"/>
    public static EmbeddingModels Version3Large { get; } = new(
        Id: Version3LargeId,
        MaxInputTokens: 8_191,
        PricePerTokenInUsd: 0.00013 * 0.001);
}