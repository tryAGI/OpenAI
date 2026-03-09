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
        this ChatModel model)
    {
        return model switch
        {
            ChatModel.O1Preview or 
                ChatModel.O1Preview20240912 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 15.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 60.00 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            ChatModel.O1Mini or 
                ChatModel.O1Mini20240912 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 3.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 12.00 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            ChatModel.Gpt4o or
                ChatModel.Gpt4o20240806 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 2.5 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 10.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            ChatModel.Gpt4o20240513 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 5.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 15.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            ChatModel.Gpt4oMini or
                ChatModel.Gpt4oMini20240718 => new ChatModelMetadata
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
            
            ChatModel.Gpt4Turbo or
                ChatModel.Gpt4Turbo20240409 or
                ChatModel.Gpt40125Preview or
                ChatModel.Gpt4TurboPreview or
                ChatModel.Gpt41106Preview or
                ChatModel.Gpt4VisionPreview => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 10.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 30.0 * UsdPerMillionTokens,
                ContextLength = 128_000,
                OutputLength = 16_000,
            },
            
            ChatModel.Gpt4 or
                ChatModel.Gpt40314 or
                ChatModel.Gpt40613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 30.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 60.0 * UsdPerMillionTokens,
                ContextLength = 8_192,
                OutputLength = 16_000,
            },
            
            ChatModel.Gpt432k or
                ChatModel.Gpt432k0314 or
                ChatModel.Gpt432k0613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 60.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 120.0 * UsdPerMillionTokens,
                ContextLength = 32_768,
                OutputLength = 16_000,
            },
            
            ChatModel.Gpt35Turbo or
                ChatModel.Gpt35Turbo0125 => new ChatModelMetadata
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
            ChatModel.Gpt35Turbo1106 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 1.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 16_385,
                OutputLength = 16_000,
            },
            ChatModel.Gpt35Turbo0613 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 1.5 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 4_096,
                OutputLength = 16_000,
            },
            ChatModel.Gpt35Turbo0301 => new ChatModelMetadata
            {
                Id = model.ToValueString(),
                PricePerInputTokenInUsd = 2.0 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.0 * UsdPerMillionTokens,
                ContextLength = 4_096,
                OutputLength = 16_000,
            },
            ChatModel.Gpt35Turbo16k or
                ChatModel.Gpt35Turbo16k0613 => new ChatModelMetadata
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
        this ChatModel model,
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

    /// <inheritdoc cref="TryGetPriceInUsd(ChatModel, int, int)"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetPriceInUsd(
        this ChatModel model,
        int inputTokens,
        int outputTokens)
    {
        return model.TryGetPriceInUsd(inputTokens, outputTokens) ??
               throw new InvalidOperationException(
                   $"Prices are not available for {model.ToValueString()}.");
    }

    /// <inheritdoc cref="TryGetFineTunePriceInUsd"/>
    public static double? TryGetFineTunePriceInUsd(
        this ChatModel model,
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
        this ChatModel model,
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
        this ChatModel model)
    {
        return model.TryGetChatModelMetadata()?.ContextLength;
    }
    
    /// <inheritdoc cref="TryGetChatModelMetadata"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int? TryGetOutputLength(
        this ChatModel model)
    {
        return model.TryGetChatModelMetadata()?.OutputLength;
    }
    
    /// <inheritdoc cref="TryGetContextLength"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetContextLength(
        this ChatModel model)
    {
        return model.TryGetContextLength() ??
               throw new InvalidOperationException(
                   $"Context length is not available for {model.ToValueString()}.");
    }
    
    /// <inheritdoc cref="TryGetOutputLength"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetOutputLength(
        this ChatModel model)
    {
        return model.TryGetOutputLength() ??
               throw new InvalidOperationException(
                   $"Output length is not available for {model.ToValueString()}.");
    }
}