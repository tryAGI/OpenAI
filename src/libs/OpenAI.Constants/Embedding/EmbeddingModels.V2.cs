// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct EmbeddingModels
{
    /// <summary>
    /// We are not deprecating text-embedding-ada-002, so while we recommend the newer model,
    /// customers are welcome to continue using the previous generation model. <br/>
    /// Max input tokens: 8,191 tokens <br/>
    /// Tokenizer: cl100k_base <br/>
    /// Output dimensions: 1536 <br/>
    /// Rough pages per dollar: 12,500 <br/>
    /// MIRACL average(1536): 31.4% <br/>
    /// MTEB average(1536): 61.0% <br/>
    /// </summary>
    internal const string Ada002Id = "text-embedding-ada-002";
    
    /// <inheritdoc cref="Ada002Id"/>
    public static EmbeddingModels Ada002 { get; } = new(
        Id: Ada002Id,
        MaxInputTokens: 8_191,
        PricePerTokenInUsd: 0.00010 * 0.001);
}