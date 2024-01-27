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

    /// <summary>
    /// Returns <see cref="ChatModels"/> by <paramref name="id"/>. <br/>
    /// Returns <see langword="null"/> if <paramref name="id"/> is not found.
    /// </summary>
    /// <param name="id">Id of the model.</param>
    /// <returns></returns>
    public static ChatModels? ById(string id)
    {
        return id switch
        {
            Gpt35Turbo_1106Id => Gpt35Turbo_1106,
            Gpt35Turbo_0125Id => Gpt35Turbo_0125,
            Gpt35TurboInstructId => Gpt35TurboInstruct,
            Gpt35TurboId => Gpt35Turbo,

            Gpt35Turbo_16kId => Gpt35Turbo_16k,
            Gpt35Turbo_0613Id => Gpt35Turbo_0613,
            Gpt35Turbo_16k_0613Id => Gpt35Turbo_16k_0613,
            Gpt35Turbo_0301Id => Gpt35Turbo_0301,
    
            Gpt4Id => Gpt4,
            Gpt4_0613Id => Gpt4_0613,
            
            Gpt4_32kId => Gpt4_32k,
            Gpt4_32k_0613Id => Gpt4_32k_0613,
            
            Gpt4_1106_PreviewId => Gpt4_1106_Preview,
            Gpt4_0125_PreviewId => Gpt4_0125_Preview,
            Gpt4TurboPreviewId => Gpt4TurboPreview,
            
            Gpt4_1106_VisionPreviewId => Gpt4_1106_VisionPreview,
            Gpt4VisionPreviewId => Gpt4VisionPreview,
    
            _ => null,
        };
    }
}