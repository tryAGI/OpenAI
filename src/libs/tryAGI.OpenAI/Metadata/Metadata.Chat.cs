// ReSharper disable once CheckNamespace
namespace tryAGI.OpenAI;

public static partial class MetadataExtensions
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static ChatModelMetadata? TryGetChatModelMetadata(
        this ModelIdsEnum model)
    {
        return model switch
        {
            ModelIdsEnum.O1Preview or 
            ModelIdsEnum.O1Preview20240912 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 15.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 60.00 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            ModelIdsEnum.O1Mini or 
            ModelIdsEnum.O1Mini20240912 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 3.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 12.00 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            ModelIdsEnum.Gpt4o or
            ModelIdsEnum.Gpt4o20240806 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 2.5 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 10.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            ModelIdsEnum.Gpt4o20240513 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 5.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 15.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            ModelIdsEnum.Gpt4oMini or
            ModelIdsEnum.Gpt4oMini20240718 => new ChatModelMetadata
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
            
            ModelIdsEnum.Gpt4Turbo or
            ModelIdsEnum.Gpt4Turbo20240409 or
            ModelIdsEnum.Gpt40125Preview or
            ModelIdsEnum.Gpt4TurboPreview or
            ModelIdsEnum.Gpt41106Preview or
            ModelIdsEnum.Gpt4VisionPreview => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 10.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 30.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            ModelIdsEnum.Gpt4 or
            ModelIdsEnum.Gpt40314 or
            ModelIdsEnum.Gpt40613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 30.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 60.0 * UsdPerMillionTokens,
                ContextLength = 8_192,
                OutputLength = 16_000,
            },
            
            ModelIdsEnum.Gpt432k or
            ModelIdsEnum.Gpt432k0314 or
            ModelIdsEnum.Gpt432k0613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 60.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 120.0 * UsdPerMillionTokens,
                ContextLength = 32_768,
                OutputLength = 16_000,
            },
            
            ModelIdsEnum.Gpt35Turbo or
            ModelIdsEnum.Gpt35Turbo0125 => new ChatModelMetadata
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
            ModelIdsEnum.Gpt35Turbo1106 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 1.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 16_385,
                OutputLength = 16_000,
            },
            ModelIdsEnum.Gpt35Turbo0613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 1.5 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 4_096,
                OutputLength = 16_000,
            },
            ModelIdsEnum.Gpt35Turbo0301 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 2.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 4_096,
                OutputLength = 16_000,
            },
            ModelIdsEnum.Gpt35Turbo16k or
            ModelIdsEnum.Gpt35Turbo16k0613 => new ChatModelMetadata
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
        this ModelIdsEnum model,
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

    /// <inheritdoc cref="TryGetPriceInUsd(ModelIdsEnum, int, int)"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetPriceInUsd(
        this ModelIdsEnum model,
        int inputTokens,
        int outputTokens)
    {
        return model.TryGetPriceInUsd(inputTokens, outputTokens) ??
               throw new InvalidOperationException(
                   $"Prices are not available for {model.ToValueString()}.");
    }

    /// <inheritdoc cref="TryGetFineTunePriceInUsd"/>
    public static double? TryGetFineTunePriceInUsd(
        this ModelIdsEnum model,
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
        this ModelIdsEnum model,
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
        this ModelIdsEnum model)
    {
        return model.TryGetChatModelMetadata()?.ContextLength;
    }
    
    /// <inheritdoc cref="TryGetChatModelMetadata"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int? TryGetOutputLength(
        this ModelIdsEnum model)
    {
        return model.TryGetChatModelMetadata()?.OutputLength;
    }
    
    /// <inheritdoc cref="TryGetContextLength"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetContextLength(
        this ModelIdsEnum model)
    {
        return model.TryGetContextLength() ??
               throw new InvalidOperationException(
                   $"Context length is not available for {model.ToValueString()}.");
    }
    
    /// <inheritdoc cref="TryGetOutputLength"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetOutputLength(
        this ModelIdsEnum model)
    {
        return model.TryGetOutputLength() ??
               throw new InvalidOperationException(
                   $"Output length is not available for {model.ToValueString()}.");
    }
}