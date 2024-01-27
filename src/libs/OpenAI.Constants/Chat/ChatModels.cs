// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ChatModels(
    string Id,
    int ContextLength,
    double PricePerInputTokenInUsd,
    double PricePerOutputTokenInUsd,
    double? FineTuningPricePerTrainingTokenInUsd = null,
    double? FineTuningPricePerInputTokenInUsd = null,
    double? FineTuningPricePerOutputTokenInUsd = null)
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

    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="trainingTokens"></param>
    /// <param name="inputTokens"></param>
    /// <param name="outputTokens"></param>
    /// <exception cref="InvalidOperationException"></exception>
    /// <returns></returns>
    public double GetFineTunePriceInUsd(
        int trainingTokens,
        int inputTokens,
        int outputTokens)
    {
        if (FineTuningPricePerTrainingTokenInUsd is null ||
            FineTuningPricePerInputTokenInUsd is null ||
            FineTuningPricePerOutputTokenInUsd is null)
        {
            throw new InvalidOperationException(
                $"Fine tuning prices are not available for {Id}.");
        }
        
        return trainingTokens * FineTuningPricePerTrainingTokenInUsd.Value +
               inputTokens * FineTuningPricePerInputTokenInUsd.Value +
               outputTokens * FineTuningPricePerOutputTokenInUsd.Value;
    }
}