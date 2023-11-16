namespace OpenAI.Constants;

/// <summary>
/// All prices in USD. <br/>
/// According https://openai.com/pricing/ <br/>
/// </summary>
public static class ChatPrices
{
    /// <inheritdoc cref="ChatPrices"/>
    /// <param name="model"></param>
    /// <param name="completionTokens"></param>
    /// <param name="promptTokens"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGet(
        ChatModel model,
        int completionTokens,
        int promptTokens)
    {
        var (promptPricePerToken, completionPricePerToken) = model.Value switch
        {
            ChatModel.Gpt4Value => (0.03 * 0.001, 0.06 * 0.001),
            ChatModel.Gpt4_0613Value => (0.03 * 0.001, 0.06 * 0.001),
            
            ChatModel.Gpt4_32kValue => (0.06 * 0.001, 0.12 * 0.001),
            ChatModel.Gpt4_32k_0613Value => (0.06 * 0.001, 0.12 * 0.001),
            
            ChatModel.Gpt35TurboValue => (0.0015 * 0.001, 0.002 * 0.001),
            ChatModel.Gpt35Turbo_0613Value => (0.0015 * 0.001, 0.002 * 0.001),
            
            ChatModel.Gpt35Turbo_16kValue =>(0.003 * 0.001, 0.004 * 0.001),
            ChatModel.Gpt35Turbo_16k_0613Value => (0.003 * 0.001, 0.004 * 0.001),
            
            _ => (-1.0, -1.0)
        };
        if (promptPricePerToken < 0.0)
        {
            return null;
        }
        
        return completionTokens * completionPricePerToken +
               promptTokens * promptPricePerToken;
    }
    
    /// <inheritdoc cref="TryGet(ChatModel, int, int)"/>
    public static double Get(
        ChatModel model,
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