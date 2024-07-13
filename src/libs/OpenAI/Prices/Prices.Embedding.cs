// ReSharper disable once CheckNamespace
namespace OpenAI;

public static partial class Prices
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="tokens"></param>
    /// <returns></returns>
    public static double GetPriceInUsd(
        this CreateEmbeddingRequestModel model,
        int tokens)
    {
        var pricePerTokenInUsd = model switch
        {
            CreateEmbeddingRequestModel.TextEmbeddingAda002 => 0.10 * UsdPerMillionTokens,
            CreateEmbeddingRequestModel.TextEmbedding3Small => 0.02 * UsdPerMillionTokens,
            CreateEmbeddingRequestModel.TextEmbedding3Large => 0.13 * UsdPerMillionTokens,
            
            _ => throw new NotImplementedException(),
        };
        
        return tokens * pricePerTokenInUsd;
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static double GetMaxInputTokens(
        this CreateEmbeddingRequestModel model)
    {
        return model switch
        {
            CreateEmbeddingRequestModel.TextEmbeddingAda002 => 8_191,
            CreateEmbeddingRequestModel.TextEmbedding3Small => 8_191,
            CreateEmbeddingRequestModel.TextEmbedding3Large => 8_191,
            
            _ => throw new NotImplementedException(),
        };
    }
}