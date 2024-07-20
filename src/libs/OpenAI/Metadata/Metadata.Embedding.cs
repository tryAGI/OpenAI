// ReSharper disable once CheckNamespace
namespace OpenAI;

public static partial class Metadata
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="tokens"></param>
    /// <returns></returns>
    public static double? TryGetPriceInUsd(
        this CreateEmbeddingRequestModel model,
        int tokens)
    {
        var pricePerTokenInUsd = model switch
        {
            CreateEmbeddingRequestModel.TextEmbeddingAda002 => 0.10 * UsdPerMillionTokens,
            CreateEmbeddingRequestModel.TextEmbedding3Small => 0.02 * UsdPerMillionTokens,
            CreateEmbeddingRequestModel.TextEmbedding3Large => 0.13 * UsdPerMillionTokens,
            
            _ => double.NaN,
        };
        if (double.IsNaN(pricePerTokenInUsd))
        {
            return null;
        }
        
        return tokens * pricePerTokenInUsd;
    }
    
    /// <inheritdoc cref="TryGetPriceInUsd(CreateEmbeddingRequestModel, int)"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetPriceInUsd(
        this CreateEmbeddingRequestModel model,
        int tokens)
    {
        return model.TryGetPriceInUsd(tokens) ??
               throw new InvalidOperationException(
                   $"Prices are not available for {model.ToValueString()}.");
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static int? TryGetMaxInputTokens(
        this CreateEmbeddingRequestModel model)
    {
        return model switch
        {
            CreateEmbeddingRequestModel.TextEmbeddingAda002 => 8_191,
            CreateEmbeddingRequestModel.TextEmbedding3Small => 8_191,
            CreateEmbeddingRequestModel.TextEmbedding3Large => 8_191,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGetMaxInputTokens"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetMaxInputTokens(
        this CreateEmbeddingRequestModel model)
    {
        return model.TryGetMaxInputTokens() ??
               throw new InvalidOperationException(
                   $"Max input tokens are not available for {model.ToValueString()}.");
    }
}