namespace OpenAI;

public partial struct ChatCompletionRequestMessage
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static implicit operator ChatCompletionRequestMessage(string content)
    {
        return ToChatCompletionRequestMessage(content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage ToChatCompletionRequestMessage(string content)
    {
        return new ChatCompletionRequestUserMessage
        {
            Role = ChatCompletionRequestUserMessageRole.User,
            Content = content,
        };
    }
}