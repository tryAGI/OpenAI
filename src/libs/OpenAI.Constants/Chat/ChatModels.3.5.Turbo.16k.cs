// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming

public readonly partial record struct ChatModels
{
    /// <inheritdoc cref="Gpt35Turbo_16k_0613Id"/>
    /// <remarks>Alias - Currently points to gpt-3.5-turbo-16k-0613.</remarks>
    internal const string Gpt35Turbo_16kId = "gpt-3.5-turbo-16k";
    
    /// <inheritdoc cref="Gpt35Turbo_16kId"/>
    public static ChatModels Gpt35Turbo_16k { get; } = new(
        Gpt35Turbo_16kId,
        ContextLength: 16_385,
        PricePerInputTokenInUsd: 0.0030 * 0.001,
        PricePerOutputTokenInUsd: 0.0040 * 0.001);
}