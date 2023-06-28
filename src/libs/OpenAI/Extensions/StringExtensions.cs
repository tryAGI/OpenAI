namespace tryAGI.OpenAI;

/// <summary>
/// 
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsSystemMessage(this string content)
    {
        return new ChatCompletionRequestMessage
        {
            Role = ChatCompletionRequestMessageRole.System,
            Content = content,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsUserMessage(this string content)
    {
        return new ChatCompletionRequestMessage
        {
            Role = ChatCompletionRequestMessageRole.User,
            Content = content,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsAssistantMessage(this string content)
    {
        return new ChatCompletionRequestMessage
        {
            Role = ChatCompletionRequestMessageRole.Assistant,
            Content = content,
        };
    }
}