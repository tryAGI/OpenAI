// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ChatModels(
    string Id,
    int ContextLength,
    double PricePerInputTokenInUsd,
    double PricePerOutputTokenInUsd)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="ChatModels"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ChatModels model)
    {
        return model.Id;
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="inputTokens"></param>
    /// <param name="outputTokens"></param>
    /// <returns></returns>
    public double GetPriceInUsd(
        int inputTokens,
        int outputTokens)
    {
        return inputTokens * PricePerInputTokenInUsd +
               outputTokens * PricePerOutputTokenInUsd;
    }
}