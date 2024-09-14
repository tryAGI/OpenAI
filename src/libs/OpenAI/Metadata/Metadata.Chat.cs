// ReSharper disable once CheckNamespace
namespace OpenAI;

public static partial class Metadata
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static ChatModelMetadata? TryGetChatModelMetadata(
        this CreateChatCompletionRequestModel model)
    {
        return model switch
        {
            CreateChatCompletionRequestModel.O1Preview or 
            CreateChatCompletionRequestModel.O1Preview20240912 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 15.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 60.00 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            CreateChatCompletionRequestModel.O1Mini or 
            CreateChatCompletionRequestModel.O1Mini20240912 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 3.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 12.00 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            CreateChatCompletionRequestModel.Gpt4o or
            CreateChatCompletionRequestModel.Gpt4o20240806 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 2.5 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 10.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            CreateChatCompletionRequestModel.Gpt4o20240513 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 5.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 15.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            CreateChatCompletionRequestModel.Gpt4oMini or
            CreateChatCompletionRequestModel.Gpt4oMini20240718 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 0.15 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 0.60 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
                
                FineTunePricePerTrainingTokenInUsd = 3.00 * UsdPerMillionTokens,
                FineTunePricePerInputTokenInUsd = 0.30 * UsdPerMillionTokens,
                FineTunePricePerOutputTokenInUsd = 1.20 * UsdPerMillionTokens,
            },
            
            CreateChatCompletionRequestModel.Gpt4Turbo or
            CreateChatCompletionRequestModel.Gpt4Turbo20240409 or
            CreateChatCompletionRequestModel.Gpt40125Preview or
            CreateChatCompletionRequestModel.Gpt4TurboPreview or
            CreateChatCompletionRequestModel.Gpt41106Preview or
            CreateChatCompletionRequestModel.Gpt4VisionPreview => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 10.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 30.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            CreateChatCompletionRequestModel.Gpt4 or
            CreateChatCompletionRequestModel.Gpt40314 or
            CreateChatCompletionRequestModel.Gpt40613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 30.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 60.0 * UsdPerMillionTokens,
                ContextLength = 8_192,
                OutputLength = 16_000,
            },
            
            CreateChatCompletionRequestModel.Gpt432k or
            CreateChatCompletionRequestModel.Gpt432k0314 or
            CreateChatCompletionRequestModel.Gpt432k0613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 60.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 120.0 * UsdPerMillionTokens,
                ContextLength = 32_768,
                OutputLength = 16_000,
            },
            
            CreateChatCompletionRequestModel.Gpt35Turbo or
            CreateChatCompletionRequestModel.Gpt35Turbo0125 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 0.5 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 1.5 * UsdPerMillionTokens,
                ContextLength = 16_385,
                OutputLength = 16_000,
                
                FineTunePricePerTrainingTokenInUsd = 8.0 * UsdPerMillionTokens,
                FineTunePricePerInputTokenInUsd = 3.0 * UsdPerMillionTokens,
                FineTunePricePerOutputTokenInUsd = 6.0 * UsdPerMillionTokens,
            },
            CreateChatCompletionRequestModel.Gpt35Turbo1106 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 1.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 16_385,
                OutputLength = 16_000,
            },
            CreateChatCompletionRequestModel.Gpt35Turbo0613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 1.5 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 4_096,
                OutputLength = 16_000,
            },
            CreateChatCompletionRequestModel.Gpt35Turbo0301 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 2.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 4_096,
                OutputLength = 16_000,
            },
            CreateChatCompletionRequestModel.Gpt35Turbo16k or
            CreateChatCompletionRequestModel.Gpt35Turbo16k0613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 3.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 4.0 * UsdPerMillionTokens,
                ContextLength = 16_385,
                OutputLength = 16_000,
            },
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGetFineTunePriceInUsd"/>
    public static double? TryGetPriceInUsd(
        this CreateChatCompletionRequestModel model,
        int inputTokens,
        int outputTokens)
    {
        var metadata = model.TryGetChatModelMetadata();
        if (metadata == null ||
            metadata.PricePerInputTokenInUsd == null ||
            metadata.PricePerOutputTokenInUsd == null)
        {
            return null;
        }
        
        return
            inputTokens * metadata.PricePerInputTokenInUsd +
            outputTokens * metadata.PricePerOutputTokenInUsd;
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

    /// <inheritdoc cref="TryGetFineTunePriceInUsd"/>
    public static double? TryGetFineTunePriceInUsd(
        this CreateChatCompletionRequestModel model,
        int trainingTokens,
        int inputTokens,
        int outputTokens)
    {
        var metadata = model.TryGetChatModelMetadata();
        if (metadata == null ||
            metadata.FineTunePricePerTrainingTokenInUsd == null ||
            metadata.FineTunePricePerInputTokenInUsd == null ||
            metadata.FineTunePricePerOutputTokenInUsd == null)
        {
            return null;
        }
        
        return trainingTokens * metadata.FineTunePricePerTrainingTokenInUsd +
               inputTokens * metadata.FineTunePricePerInputTokenInUsd +
               outputTokens * metadata.FineTunePricePerOutputTokenInUsd;
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
    
    /// <inheritdoc cref="TryGetChatModelMetadata"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int? TryGetContextLength(
        this CreateChatCompletionRequestModel model)
    {
        return model.TryGetChatModelMetadata()?.ContextLength;
    }
    
    /// <inheritdoc cref="TryGetChatModelMetadata"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int? TryGetOutputLength(
        this CreateChatCompletionRequestModel model)
    {
        return model.TryGetChatModelMetadata()?.OutputLength;
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
    
    /// <inheritdoc cref="TryGetOutputLength"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetOutputLength(
        this CreateChatCompletionRequestModel model)
    {
        return model.TryGetOutputLength() ??
               throw new InvalidOperationException(
                   $"Output length is not available for {model.ToValueString()}.");
    }
}