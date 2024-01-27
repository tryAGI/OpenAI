// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According:
/// - https://platform.openai.com/docs/models/
/// - https://openai.com/blog/new-embedding-models-and-api-updates
/// - https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo
/// <remarks>
/// OpenAI models are non-deterministic, meaning that identical inputs can yield different outputs.
/// Setting temperature to 0 will make the outputs mostly deterministic, but a small amount of variability may remain.
/// </remarks>
/// </summary>
/// <param name="Id">Id of the model.</param>
/// <param name="ContextLength">The maximum number of input tokens.</param>
/// <param name="PricePerInputTokenInUsd">Price per input token in USD.</param>
/// <param name="PricePerOutputTokenInUsd">Price per output token in USD.</param>
/// <param name="FineTuningPricePerTrainingTokenInUsd">Fine tuning price per training token in USD.</param>
/// <param name="FineTuningPricePerInputTokenInUsd">Fine tuning price per input token in USD.</param>
/// <param name="FineTuningPricePerOutputTokenInUsd">Fine tuning price per output token in USD.</param>
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