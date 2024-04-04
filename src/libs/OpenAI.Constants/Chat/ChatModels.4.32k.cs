// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModels
{
    /// <summary>
    /// Snapshot of gpt-4-32k from June 13th 2023 with improved function calling support. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max tokens: 32,768 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt4_32k_0613Id = "gpt-4-32k-0613";
    
    /// <inheritdoc cref="Gpt4_32k_0613Id"/>
    /// <remarks>Alias - Currently points to gpt-4-32k-0613</remarks>
    internal const string Gpt4_32kId = "gpt-4-32";
    
    /// <inheritdoc cref="Gpt4_32k_0613Id"/>
    public static ChatModels Gpt4_32k_0613 { get; } = new(
        Id: Gpt4_32k_0613Id,
        ContextLength: 32_768,
        PricePerInputTokenInUsd: 60.0 * UsdPerMillionTokens,
        PricePerOutputTokenInUsd: 120.0 * UsdPerMillionTokens);
    
    /// <inheritdoc cref="Gpt4_32kId"/>
    public static ChatModels Gpt4_32k { get; } = Gpt4_32k_0613 with
    {
        Id = Gpt4_32k_0613Id,
    };
}