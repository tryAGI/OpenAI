// ReSharper disable once CheckNamespace
namespace OpenAI;

public static partial class Prices
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="inputTokens"></param>
    /// <param name="outputTokens"></param>
    /// <returns></returns>
    public static double? TryGetPriceInUsd(
        this CreateChatCompletionRequestModel model,
        int inputTokens,
        int outputTokens)
    {
        var (pricePerInputTokenInUsd, pricePerOutputTokenInUsd) = model switch
        {
            CreateChatCompletionRequestModel.Gpt4o => (5.0 * UsdPerMillionTokens, 15.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt4o20240513 => (5.0 * UsdPerMillionTokens, 15.0 * UsdPerMillionTokens),
            
            CreateChatCompletionRequestModel.Gpt4oMini => (0.15 * UsdPerMillionTokens, 0.60 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt4oMini20240718 => (0.15 * UsdPerMillionTokens, 0.60 * UsdPerMillionTokens),
            
            CreateChatCompletionRequestModel.Gpt4Turbo => (10.0 * UsdPerMillionTokens, 30.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt4Turbo20240409 => (10.0 * UsdPerMillionTokens, 30.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt40125Preview => (10.0 * UsdPerMillionTokens, 30.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt4TurboPreview => (10.0 * UsdPerMillionTokens, 30.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt41106Preview => (10.0 * UsdPerMillionTokens, 30.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt4VisionPreview => (10.0 * UsdPerMillionTokens, 30.0 * UsdPerMillionTokens),
            
            CreateChatCompletionRequestModel.Gpt4 => (30.0 * UsdPerMillionTokens, 60.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt40314 => (30.0 * UsdPerMillionTokens, 60.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt40613 => (30.0 * UsdPerMillionTokens, 60.0 * UsdPerMillionTokens),
            
            CreateChatCompletionRequestModel.Gpt432k => (60.0 * UsdPerMillionTokens, 120.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt432k0314 => (60.0 * UsdPerMillionTokens, 120.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt432k0613 => (60.0 * UsdPerMillionTokens, 120.0 * UsdPerMillionTokens),
            
            CreateChatCompletionRequestModel.Gpt35Turbo => (0.5 * UsdPerMillionTokens, 1.5 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt35Turbo0125 => (0.5 * UsdPerMillionTokens, 1.5 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt35Turbo1106 => (1.0 * UsdPerMillionTokens, 2.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt35Turbo0613 => (1.5 * UsdPerMillionTokens, 2.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt35Turbo0301 => (2.0 * UsdPerMillionTokens, 2.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt35Turbo16k => (3.0 * UsdPerMillionTokens, 4.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt35Turbo16k0613 => (3.0 * UsdPerMillionTokens, 4.0 * UsdPerMillionTokens),
            
            _ => (double.NaN, double.NaN),
        };
        if (double.IsNaN(pricePerInputTokenInUsd) ||
            double.IsNaN(pricePerOutputTokenInUsd))
        {
            return null;
        }
        
        return
            inputTokens * pricePerInputTokenInUsd +
            outputTokens * pricePerOutputTokenInUsd;
    }

    /// <inheritdoc cref="TryGetPriceInUsd(CreateChatCompletionRequestModel, int, int)"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetPriceInUsd(
        this CreateChatCompletionRequestModel model,
        int inputTokens,
        int outputTokens)
    {
        return model.TryGetPriceInUsd(inputTokens, outputTokens) ??
               throw new InvalidOperationException(
                   $"Prices are not available for {model.ToValueString()}.");
    }

    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="trainingTokens"></param>
    /// <param name="inputTokens"></param>
    /// <param name="outputTokens"></param>
    /// <exception cref="InvalidOperationException"></exception>
    /// <returns></returns>
    public static double? TryGetFineTunePriceInUsd(
        this CreateChatCompletionRequestModel model,
        int trainingTokens,
        int inputTokens,
        int outputTokens)
    {
        var (pricePerTrainingTokenInUsd, pricePerInputTokenInUsd, pricePerOutputTokenInUsd) = model switch
        {
            CreateChatCompletionRequestModel.Gpt35Turbo => (8.0 * UsdPerMillionTokens, 3.0 * UsdPerMillionTokens, 6.0 * UsdPerMillionTokens),
            CreateChatCompletionRequestModel.Gpt35Turbo0125 => (8.0 * UsdPerMillionTokens, 3.0 * UsdPerMillionTokens, 6.0 * UsdPerMillionTokens),
            
            _ => (double.NaN, double.NaN, double.NaN),
        };
        if (double.IsNaN(pricePerTrainingTokenInUsd) ||
            double.IsNaN(pricePerInputTokenInUsd) ||
            double.IsNaN(pricePerOutputTokenInUsd))
        {
            return null;
        }
        
        return trainingTokens * pricePerTrainingTokenInUsd +
               inputTokens * pricePerInputTokenInUsd +
               outputTokens * pricePerOutputTokenInUsd;
    }

    /// <inheritdoc cref="TryGetFineTunePriceInUsd"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetFineTunePriceInUsd(
        this CreateChatCompletionRequestModel model,
        int trainingTokens,
        int inputTokens,
        int outputTokens)
    {
        return model.TryGetFineTunePriceInUsd(trainingTokens, inputTokens, outputTokens) ??
               throw new InvalidOperationException(
                   $"Fine tuning prices are not available for {model.ToValueString()}.");
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static int? TryGetContextLength(
        this CreateChatCompletionRequestModel model)
    {
        return model switch
        {
            CreateChatCompletionRequestModel.Gpt4o => 128_000,
            CreateChatCompletionRequestModel.Gpt4o20240513 => 128_000,
            
            CreateChatCompletionRequestModel.Gpt4oMini => 128_000,
            CreateChatCompletionRequestModel.Gpt4oMini20240718 => 128_000,
            
            CreateChatCompletionRequestModel.Gpt4Turbo => 128_000,
            CreateChatCompletionRequestModel.Gpt4Turbo20240409 => 128_000,
            CreateChatCompletionRequestModel.Gpt40125Preview => 128_000,
            CreateChatCompletionRequestModel.Gpt4TurboPreview => 128_000,
            CreateChatCompletionRequestModel.Gpt41106Preview => 128_000,
            CreateChatCompletionRequestModel.Gpt4VisionPreview => 128_000,
            
            CreateChatCompletionRequestModel.Gpt4 => 8_192,
            CreateChatCompletionRequestModel.Gpt40314 => 8_192,
            CreateChatCompletionRequestModel.Gpt40613 => 8_192,
            
            CreateChatCompletionRequestModel.Gpt432k => 32_768,
            CreateChatCompletionRequestModel.Gpt432k0314 => 32_768,
            CreateChatCompletionRequestModel.Gpt432k0613 => 32_768,
            
            CreateChatCompletionRequestModel.Gpt35Turbo => 4_096,
            CreateChatCompletionRequestModel.Gpt35Turbo0301 => 4_096,
            CreateChatCompletionRequestModel.Gpt35Turbo0613 => 4_096,
            CreateChatCompletionRequestModel.Gpt35Turbo1106 => 16_385,
            CreateChatCompletionRequestModel.Gpt35Turbo0125 => 16_385,
            CreateChatCompletionRequestModel.Gpt35Turbo16k => 16_385,
            CreateChatCompletionRequestModel.Gpt35Turbo16k0613 => 16_385,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGetContextLength"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetContextLength(
        this CreateChatCompletionRequestModel model)
    {
        return model.TryGetContextLength() ??
               throw new InvalidOperationException(
                   $"Context length is not available for {model.ToValueString()}.");
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static int? TryGetOutputLength(
        this CreateChatCompletionRequestModel model)
    {
        return model switch
        {
            CreateChatCompletionRequestModel.Gpt4oMini => 16_000,
            CreateChatCompletionRequestModel.Gpt4oMini20240718 => 16_000,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGetOutputLength"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetOutputLength(
        this CreateChatCompletionRequestModel model)
    {
        return model.TryGetOutputLength() ??
               throw new InvalidOperationException(
                   $"Context length is not available for {model.ToValueString()}.");
    }
}