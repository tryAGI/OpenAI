// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModels
{
    /// <summary>
    /// The latest GPT-3.5 Turbo model with improved instruction following, JSON mode, reproducible outputs,
    /// parallel function calling, and more. <br/>
    /// Max input tokens: 16,385 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35Turbo_1106Id = "gpt-3.5-turbo-1106";
    
    /// <summary>
    /// Similar capabilities as GPT-3 era models. Compatible with legacy Completions endpoint and not Chat Completions. <br/>
    /// Max tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35TurboInstructId = "gpt-3.5-turbo-instruct";
    
    /// <summary>
    /// This model will also have various improvements including higher accuracy
    /// at responding in requested formats and a fix for a bug
    /// which caused a text encoding issue for non-English language function calls. <br/>
    /// Max input tokens: 16,385 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35Turbo_0125Id = "gpt-3.5-turbo-0125";
    
    /// <inheritdoc cref="Gpt35Turbo_0613Id"/>
    /// <remarks>Alias - Currently points to gpt-3.5-turbo-0613.</remarks>
    internal const string Gpt35TurboId = "gpt-3.5-turbo";
    
    /// <inheritdoc cref="Gpt35Turbo_1106Id"/>
    public static ChatModels Gpt35Turbo_1106 { get; } = new(
        Id: Gpt35Turbo_1106Id,
        ContextLength: 16_385,
        PricePerInputTokenInUsd: 0.0010 * 0.001,
        PricePerOutputTokenInUsd: 0.0020 * 0.001);
    
    /// <inheritdoc cref="Gpt35Turbo_0125Id"/>
    public static ChatModels Gpt35Turbo_0125 { get; } = new(
        Id: Gpt35Turbo_0125Id,
        ContextLength: 16_385,
        PricePerInputTokenInUsd: 0.0005 * 0.001,
        PricePerOutputTokenInUsd: 0.0015 * 0.001);
    
    /// <inheritdoc cref="Gpt35TurboInstructId"/>
    public static ChatModels Gpt35TurboInstruct { get; } = new(
        Id: Gpt35TurboInstructId,
        ContextLength: 4_096,
        PricePerInputTokenInUsd: 0.0015 * 0.001,
        PricePerOutputTokenInUsd: 0.0020 * 0.001);
    
    /// <inheritdoc cref="Gpt35TurboId"/>
    // ReSharper disable once StaticMemberInitializerReferesToMemberBelow
    public static ChatModels Gpt35Turbo { get; } = Gpt35Turbo_0613 with
    {
        Id = Gpt35TurboId,
    };
}