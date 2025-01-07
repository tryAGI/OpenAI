namespace tryAGI.OpenAI;

public partial struct ChatCompletionRequestMessage
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static implicit operator ChatCompletionRequestMessage(string content)
    {
        return FromString(content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static implicit operator ChatCompletionRequestMessage(Uri uri)
    {
        return FromUri(uri);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage FromString(string content)
    {
        return new ChatCompletionRequestUserMessage
        {
            Role = ChatCompletionRequestUserMessageRole.User,
            Content = content,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage FromUri(Uri uri)
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="mimeType"></param>
    /// <param name="detail"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static ChatCompletionRequestMessage FromDataUri(
        byte[] bytes,
        string mimeType,
        ChatCompletionRequestMessageContentPartImageImageUrlDetail detail = ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto)
    {
        bytes = bytes ?? throw new ArgumentNullException(nameof(bytes));
        
        return new ChatCompletionRequestUserMessage
        {
            Content = new ChatCompletionRequestUserMessageContentPart[] {
                new ChatCompletionRequestMessageContentPartImage
                {
                    ImageUrl = new ChatCompletionRequestMessageContentPartImageImageUrl
                    {
                        Url = bytes.AsDataUrl(mimeType),
                        Detail = detail,
                    },
                    Type = ChatCompletionRequestMessageContentPartImageType.ImageUrl,
                },
            },
        };
    }
}