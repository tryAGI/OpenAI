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
/// <param name="Id">Id of the model.</param>
/// <param name="MaxInputTokens">Max input tokens.</param>
/// <param name="PricePerTokenInUsd">Price per token in USD.</param>
public readonly partial record struct EmbeddingModels(
    string Id,
    int MaxInputTokens,
    double PricePerTokenInUsd)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="EmbeddingModels"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(EmbeddingModels model)
    {
        return model.Id;
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="tokens"></param>
    /// <returns></returns>
    public double GetPriceInUsd(
        int tokens)
    {
        return tokens * PricePerTokenInUsd;
    }
}