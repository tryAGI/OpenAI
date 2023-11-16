namespace OpenAI.Constants;

/// <summary>
/// All prices in USD. <br/>
/// According https://openai.com/pricing/ <br/>
/// </summary>
public static class ChatPrices
{
    /// <inheritdoc cref="ChatPrices"/>
    /// <param name="model"></param>
    /// <param name="outputTokens"></param>
    /// <param name="inputTokens"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGet(
        ChatModel model,
        int outputTokens,
        int inputTokens)
    {
        var (inputPricePerToken, outputPricePerToken) = model.Value switch
        {
            ChatModel.Gpt4Value => (0.03 * 0.001, 0.06 * 0.001),
            ChatModel.Gpt4_0613Value => (0.03 * 0.001, 0.06 * 0.001),
            
            ChatModel.Gpt4_32kValue => (0.06 * 0.001, 0.12 * 0.001),
            ChatModel.Gpt4_32k_0613Value => (0.06 * 0.001, 0.12 * 0.001),
            
            ChatModel.Gpt4_1106_PreviewValue => (0.01 * 0.001, 0.03 * 0.001),
            ChatModel.Gpt4VisionPreviewValue => (0.01 * 0.001, 0.03 * 0.001),
            
            ChatModel.Gpt35TurboValue => (0.0015 * 0.001, 0.002 * 0.001),
            ChatModel.Gpt35Turbo_0613Value => (0.0015 * 0.001, 0.002 * 0.001),
            
            ChatModel.Gpt35Turbo_16kValue =>(0.003 * 0.001, 0.004 * 0.001),
            ChatModel.Gpt35Turbo_16k_0613Value => (0.003 * 0.001, 0.004 * 0.001),
            
            _ => (-1.0, -1.0)
        };
        if (inputPricePerToken < 0.0)
        {
            return null;
        }
        
        return outputTokens * outputPricePerToken +
               inputTokens * inputPricePerToken;
    }
    
    /// <inheritdoc cref="TryGet(ChatModel, int, int)"/>
    public static double Get(
        ChatModel model,
        int outputTokens,
        int inputTokens)
    {
        return TryGet(
                   model: model,
                   outputTokens: outputTokens,
                   inputTokens: inputTokens) ??
               throw new NotImplementedException();
    }
}