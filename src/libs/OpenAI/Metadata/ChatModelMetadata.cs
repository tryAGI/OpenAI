namespace OpenAI;

/// <summary>
/// Metadata for chat models.
/// </summary>
public class ChatModelMetadata
{
    /// <summary>
    /// Price per training token in USD.
    /// </summary>
    public string? Id { get; init; }
    
    /// <summary>
    /// Price per training token in USD.
    /// </summary>
    public double? PricePerInputTokenInUsd { get; init; }
    
    /// <summary>
    /// Price per input token in USD.
    /// </summary>
    public double? PricePerOutputTokenInUsd { get; init; }
    
    /// <summary>
    /// Fine-tune price per training token in USD.
    /// </summary>
    public double? FineTunePricePerTrainingTokenInUsd { get; init; }
    
    /// <summary>
    /// Fine-tune price per input token in USD.
    /// </summary>
    public double? FineTunePricePerInputTokenInUsd { get; init; }
    
    /// <summary>
    /// Fine-tune price per output token in USD.
    /// </summary>
    public double? FineTunePricePerOutputTokenInUsd { get; init; }
    
    /// <summary>
    /// Context length in tokens.
    /// </summary>
    public int? ContextLength { get; init; }
    
    /// <summary>
    /// Output length in tokens.
    /// </summary>
    public int? OutputLength { get; init; }
}