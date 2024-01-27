// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct EmbeddingModel(
    string Value,
    int MaxInputTokens,
    double PricePerTokenInUsd)
{
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