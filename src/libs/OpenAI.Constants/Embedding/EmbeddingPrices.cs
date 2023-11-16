namespace OpenAI.Constants;

/// <summary>
/// All prices in USD. <br/>
/// According https://openai.com/pricing/ <br/>
/// According https://platform.openai.com/docs/guides/embeddings/embedding-models &lt;br/&gt;
/// </summary>
public static class EmbeddingPrices
{
    /// <inheritdoc cref="EmbeddingPrices"/>
    /// <param name="model"></param>
    /// <param name="completionTokens"></param>
    /// <param name="promptTokens"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGet(
        EmbeddingModel model,
        int completionTokens,
        int promptTokens)
    {
        var (promptPricePerToken, completionPricePerToken) = model.Value switch
        {
            EmbeddingModel.Ada002Value => (0.0001 * 0.001, 0.0),
            
            _ => (-1.0, -1.0)
        };
        if (promptPricePerToken < 0.0)
        {
            return null;
        }
        
        return completionTokens * completionPricePerToken +
               promptTokens * promptPricePerToken;
    }
    
    /// <inheritdoc cref="TryGet(EmbeddingModel, int, int)"/>
    public static double Get(
        EmbeddingModel model,
        int completionTokens,
        int promptTokens)
    {
        return TryGet(
                   model: model,
                   completionTokens: completionTokens,
                   promptTokens: promptTokens) ??
               throw new NotImplementedException();
    }
}