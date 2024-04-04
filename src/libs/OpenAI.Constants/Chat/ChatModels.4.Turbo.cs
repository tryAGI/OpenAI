// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModels
{
    /// <summary>
    /// The GPT-4 model with improved instruction following, JSON mode, reproducible outputs,
    /// parallel function calling, and more.
    /// This preview model is not yet suited for production traffic. <br/>
    /// Max input tokens: 128,000 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Apr 2023 <br/>
    /// </summary>
    internal const string Gpt4_1106_PreviewId = "gpt-4-1106-preview";
    
    /// <summary>
    /// Today, we are releasing an updated GPT-4 Turbo preview model, gpt-4-0125-preview.
    /// This model completes tasks like code generation more thoroughly than the previous preview model
    /// and is intended to reduce cases of “laziness” where the model doesn’t complete a task.
    /// The new model also includes the fix for the bug impacting non-English UTF-8 generations. <br/>
    /// Max input tokens: 128,000 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Apr 2023 <br/>
    /// </summary>
    internal const string Gpt4_0125_PreviewId = "gpt-4-0125-preview";

    /// <inheritdoc cref="Gpt4_0125_PreviewId"/>
    /// <remarks>Alias - Currently points to gpt-4-0125-preview.</remarks>
    internal const string Gpt4TurboPreviewId = "gpt-4-turbo-preview";
    
    /// <inheritdoc cref="Gpt4_1106_PreviewId"/>
    public static ChatModels Gpt4_1106_Preview { get; } = new(
        Id: Gpt4_1106_PreviewId,
        ContextLength: 128_000,
        PricePerInputTokenInUsd: 10.0 * UsdPerMillionTokens,
        PricePerOutputTokenInUsd: 30.0 * UsdPerMillionTokens);
    
    /// <inheritdoc cref="Gpt4_0125_PreviewId"/>
    public static ChatModels Gpt4_0125_Preview { get; } = new(
        Id: Gpt4_0125_PreviewId,
        ContextLength: 128_000,
        PricePerInputTokenInUsd: 10.0 * UsdPerMillionTokens,
        PricePerOutputTokenInUsd: 30.0 * UsdPerMillionTokens);
    
    /// <inheritdoc cref="Gpt4TurboPreviewId"/>
    public static ChatModels Gpt4TurboPreview { get; } = Gpt4_0125_Preview with
    {
        Id = Gpt4TurboPreviewId,
    };
}