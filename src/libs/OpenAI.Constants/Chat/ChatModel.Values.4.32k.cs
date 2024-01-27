// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModel
{
    /// <summary>
    /// Snapshot of gpt-4-32k from June 13th 2023 with improved function calling support. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max tokens: 32,768 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt4_32k_0613Value = "gpt-4-32k-0613";
    
    /// <inheritdoc cref="Gpt4_32k_0613Value"/>
    /// <remarks>Alias - Currently points to gpt-4-32k-0613</remarks>
    internal const string Gpt4_32kValue = "gpt-4-32";
    
    /// <inheritdoc cref="Gpt4_32k_0613Value"/>
    public static ChatModel Gpt4_32k_0613 { get; } = new(Gpt4_32k_0613Value);
    
    /// <inheritdoc cref="Gpt4_32kValue"/>
    public static ChatModel Gpt4_32k { get; } = new(Gpt4_32kValue);
}