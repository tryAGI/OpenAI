namespace tryAGI.OpenAI;

public partial struct ChatCompletionRequestUserMessageContentPart
{
    /// <inheritdoc />
    public override string ToString()
    {
        return IsText
            ? Text?.Text ?? string.Empty
            : IsImage
                ? Image?.ImageUrl.Url ?? string.Empty
                : string.Empty;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    public static implicit operator string(ChatCompletionRequestUserMessageContentPart response)
    {
#pragma warning disable CA1062
        return response.ToString();
#pragma warning restore CA1062
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static implicit operator ChatCompletionRequestUserMessageContentPart(string content)
    {
        return FromString(content);
    }
    
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static implicit operator ChatCompletionRequestUserMessageContentPart(Uri uri)
    {
        return FromUri(uri);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static ChatCompletionRequestUserMessageContentPart FromString(string content)
    {
        return new ChatCompletionRequestUserMessageContentPart(new ChatCompletionRequestMessageContentPartText
        {
            Text = "describe the following image in a few sentences",
            Type = ChatCompletionRequestMessageContentPartTextType.Text,
        });
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static ChatCompletionRequestUserMessageContentPart FromUri(Uri uri)
    {
        uri = uri ?? throw new ArgumentNullException(nameof(uri));
        
        return new ChatCompletionRequestUserMessageContentPart(new ChatCompletionRequestMessageContentPartImage
        {
            ImageUrl = new ChatCompletionRequestMessageContentPartImageImageUrl
            {
                Url = uri.ToString(),
                Detail = ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto,
            },
            Type = ChatCompletionRequestMessageContentPartImageType.ImageUrl,
        });
    }
}