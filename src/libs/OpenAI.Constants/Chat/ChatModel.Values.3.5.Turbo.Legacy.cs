// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModel
{
    /// <summary>
    /// Snapshot of gpt-3.5-turbo from June 13th 2023 with function calling data. <br/>
    /// Unlike gpt-3.5-turbo, this model will not receive updates, and will be deprecated 3 months after a new version is released. <br/>
    /// Max tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    [Obsolete("Marked as Legacy. Will be deprecated on June 13, 2024.")]
    internal const string Gpt35Turbo_0613Value = "gpt-3.5-turbo-0613";
    
    /// <summary>
    /// Snapshot of gpt-3.5-turbo-16k from June 13th 2023. <br/>
    /// Unlike gpt-3.5-turbo-16k, this model will not receive updates, and will be deprecated 3 months after a new version is released. <br/>
    /// Max tokens: 16,384 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    [Obsolete("Marked as Legacy. Will be deprecated on June 13, 2024.")]
    internal const string Gpt35Turbo_16k_0613Value = "gpt-3.5-turbo-16k-0613";
    
    /// <summary>
    /// Snapshot of gpt-3.5-turbo from March 1st 2023. <br/>
    /// Max tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    [Obsolete("Marked as Legacy. Will be deprecated on June 13, 2024.")]
    internal const string Gpt35Turbo_0301Value = "gpt-3.5-turbo-0301";
    
    /// <inheritdoc cref="Gpt35Turbo_0613Value"/>
    [Obsolete("Marked as Legacy. Will be deprecated on June 13, 2024.")]
    public static ChatModel Gpt35Turbo_0613 { get; } = new(Gpt35Turbo_0613Value);
    
    /// <inheritdoc cref="Gpt35Turbo_16k_0613Value"/>
    [Obsolete("Marked as Legacy. Will be deprecated on June 13, 2024.")]
    public static ChatModel Gpt35Turbo_16k_0613 { get; } = new(Gpt35Turbo_16k_0613Value);
    
    /// <inheritdoc cref="Gpt35Turbo_0301Value"/>
    [Obsolete("Marked as Legacy. Will be deprecated on June 13, 2024.")]
    public static ChatModel Gpt35Turbo_0301 { get; } = new(Gpt35Turbo_0301Value);
}