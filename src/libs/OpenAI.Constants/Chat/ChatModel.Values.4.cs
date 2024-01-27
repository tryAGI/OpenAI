// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModel
{
    /// <summary>
    /// Snapshot of gpt-4 from June 13th 2023 with improved function calling support. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max tokens: 8,192 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt4_0613Value = "gpt-4-0613";
    
    /// <inheritdoc cref="Gpt4_0613Value"/>
    /// <remarks>Alias - Currently points to gpt-4-0613.</remarks>
    internal const string Gpt4Value = "gpt-4";
    
    /// <inheritdoc cref="Gpt4_0613Value"/>
    public static ChatModel Gpt4_0613 { get; } = new(Gpt4_0613Value);
    
    /// <inheritdoc cref="Gpt4Value"/>
    public static ChatModel Gpt4 { get; } = new(Gpt4Value);
}