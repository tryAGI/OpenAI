namespace OpenAI.Constants;

/// <summary>
/// All prices in USD. <br/>
/// According https://openai.com/pricing/ <br/>
/// According https://platform.openai.com/docs/guides/embeddings/embedding-models <br/>
/// </summary>
public static class EmbeddingPrices
{
    /// <inheritdoc cref="EmbeddingPrices"/>
    /// <param name="model"></param>
    /// <param name="tokens"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGet(
        EmbeddingModel model,
        int tokens)
    {
        var pricePerToken = model.Value switch
        {
            EmbeddingModel.Ada002Value => 0.0001 * 0.001,
            
            _ => -1.0,
        };
        if (pricePerToken < 0.0)
        {
            return null;
        }
        
        return tokens * pricePerToken;
    }
    
    /// <inheritdoc cref="TryGet(EmbeddingModel, int)"/>
    public static double Get(
        EmbeddingModel model,
        int tokens)
    {
        return TryGet(
                   model: model,
                   tokens: tokens) ??
               throw new NotImplementedException();
    }
}