namespace OpenAI;

public partial class ChatCompletionRequestUserMessage
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static implicit operator ChatCompletionRequestUserMessage(Uri uri)
    {
        return FromUri(uri);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static ChatCompletionRequestUserMessage FromUri(Uri uri)
    {
        return new ChatCompletionRequestUserMessage
        {
            Role = ChatCompletionRequestUserMessageRole.User,
            Content = new ChatCompletionRequestUserMessageContentPart[]
            {
                uri,
            },
        };
    }
}