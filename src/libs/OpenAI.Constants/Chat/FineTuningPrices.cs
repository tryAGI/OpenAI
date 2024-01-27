// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// All prices in USD. <br/>
/// According https://openai.com/pricing/ <br/>
/// </summary>
public static class FineTuningPrices
{
    /// <inheritdoc cref="FineTuningPrices"/>
    /// <param name="model"></param>
    /// <param name="trainingTokens"></param>
    /// <param name="inputTokens"></param>
    /// <param name="outputTokens"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGet(
        ChatModel model,
        int trainingTokens,
        int inputTokens,
        int outputTokens)
    {
        var (trainingPricePerToken, inputPricePerToken, outputPricePerToken) = model.Id switch
        {
            ChatModel.Gpt35TurboId => (0.0080 * 0.001, 0.0030 * 0.001, 0.0060 * 0.001),
            
            _ => (-1.0, -1.0, -1.0),
        };
        if (trainingPricePerToken < 0.0)
        {
            return null;
        }
        
        return trainingTokens * trainingPricePerToken +
               inputTokens * inputPricePerToken +
               outputTokens * outputPricePerToken;
    }
    
    /// <inheritdoc cref="TryGet(ChatModel, int, int, int)"/>
    public static double Get(
        ChatModel model,
        int trainingTokens,
        int inputTokens,
        int outputTokens)
    {
        return TryGet(
                   model: model,
                   trainingTokens: trainingTokens,
                   inputTokens: inputTokens,
                   outputTokens: outputTokens) ??
               throw new NotImplementedException();
    }
}