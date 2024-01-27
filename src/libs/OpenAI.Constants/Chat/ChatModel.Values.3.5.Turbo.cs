// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModel
{
    /// <summary>
    /// The latest GPT-3.5 Turbo model with improved instruction following, JSON mode, reproducible outputs,
    /// parallel function calling, and more. <br/>
    /// Max input tokens: 16,385 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35Turbo_1106Value = "gpt-3.5-turbo-1106";
    
    /// <summary>
    /// Similar capabilities as GPT-3 era models. Compatible with legacy Completions endpoint and not Chat Completions. <br/>
    /// Max tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35TurboInstructValue = "gpt-3.5-turbo-instruct";
    
    /// <summary>
    /// This model will also have various improvements including higher accuracy
    /// at responding in requested formats and a fix for a bug
    /// which caused a text encoding issue for non-English language function calls. <br/>
    /// Max input tokens: 16,385 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35Turbo_0125Value = "gpt-3.5-turbo-0125";
    
    /// <inheritdoc cref="Gpt35Turbo_0613Value"/>
    /// <remarks>Alias - Currently points to gpt-3.5-turbo-0613.</remarks>
    internal const string Gpt35TurboValue = "gpt-3.5-turbo";
    
    /// <inheritdoc cref="Gpt35Turbo_1106Value"/>
    public static ChatModel Gpt35Turbo_1106 { get; } = new(Gpt35Turbo_1106Value, ContextLength: 16_385);
    
    /// <inheritdoc cref="Gpt35Turbo_0125Value"/>
    public static ChatModel Gpt35Turbo_0125 { get; } = new(Gpt35Turbo_0125Value, ContextLength: 16_385);
    
    /// <inheritdoc cref="Gpt35TurboInstructValue"/>
    public static ChatModel Gpt35TurboInstruct { get; } = new(Gpt35TurboInstructValue, ContextLength: 4_096);
    
    /// <inheritdoc cref="Gpt35TurboValue"/>
    public static ChatModel Gpt35Turbo { get; } = new(Gpt35TurboValue, ContextLength: 4_096);
}