// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModels
{
    /// <summary>
    /// Our most advanced, multimodal flagship model that’s cheaper and faster than GPT-4 Turbo. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4o <br/>
    /// Max input tokens: 128,000 tokens <br/>
    /// Max output tokens: 4,096 tokens <br/>
    /// Training data: Up to Oct 2023 <br/>
    /// </summary>
    internal const string Gpt4o_2024_05_13Id = "gpt-4o-2024-05-13";
    
    /// <inheritdoc cref="Gpt4o_2024_05_13Id"/>
    /// <remarks>Alias - Currently points to gpt-4-1106-vision-preview.</remarks>
    internal const string Gpt4oId = "gpt-4o";
    
    /// <inheritdoc cref="Gpt4o_2024_05_13Id"/>
    public static ChatModels Gpt4o_2024_05_13 { get; } = new(
        Gpt4o_2024_05_13Id,
        ContextLength: 128_000,
        PricePerInputTokenInUsd: 5.0 * UsdPerMillionTokens,
        PricePerOutputTokenInUsd: 15.0 * UsdPerMillionTokens);
    
    /// <inheritdoc cref="Gpt4o_2024_05_13Id"/>
    public static ChatModels Gpt4o { get; } = Gpt4o_2024_05_13 with
    {
        Id = Gpt4oId,
    };
}