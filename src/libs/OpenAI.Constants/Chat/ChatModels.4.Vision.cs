// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModels
{
    /// <summary>
    /// Ability to understand images, in addition to all other GPT-4 Turbo capabilities.
    /// This is a preview model version and not suited yet for production traffic. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max input tokens: 128,000 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Apr 2023 <br/>
    /// </summary>
    internal const string Gpt4_1106_VisionPreviewId = "gpt-4-1106-vision-preview";
    
    /// <inheritdoc cref="Gpt4_1106_VisionPreviewId"/>
    /// <remarks>Alias - Currently points to gpt-4-1106-vision-preview.</remarks>
    internal const string Gpt4VisionPreviewId = "gpt-4-vision-preview";
    
    /// <inheritdoc cref="Gpt4_1106_VisionPreviewId"/>
    public static ChatModels Gpt4_1106_VisionPreview { get; } = new(
        Gpt4_1106_VisionPreviewId,
        ContextLength: 128_000,
        PricePerInputTokenInUsd: 10.0 * UsdPerMillionTokens,
        PricePerOutputTokenInUsd: 30.0 * UsdPerMillionTokens);
    
    /// <inheritdoc cref="Gpt4VisionPreviewId"/>
    public static ChatModels Gpt4VisionPreview { get; } = Gpt4_1106_VisionPreview with
    {
        Id = Gpt4VisionPreviewId,
    };
}