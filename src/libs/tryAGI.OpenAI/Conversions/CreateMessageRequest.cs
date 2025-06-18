namespace tryAGI.OpenAI;

public partial class CreateMessageRequest
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public static implicit operator CreateMessageRequest(OpenAIFile file)
    {
        return FromOpenAIFile(file);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static implicit operator CreateMessageRequest(string content)
    {
        return FromString(content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static implicit operator CreateMessageRequest(Uri uri)
    {
        return FromUri(uri);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <param name="role"></param>
    /// <param name="detail"></param>
    /// <returns></returns>
    public static CreateMessageRequest FromOpenAIFile(
        OpenAIFile file,
        MessageContentImageFileObjectImageFileDetail detail = MessageContentImageFileObjectImageFileDetail.Auto,
        CreateMessageRequestRole role = CreateMessageRequestRole.User)
    {
        file = file ?? throw new ArgumentNullException(nameof(file));

        return new CreateMessageRequest
        {
            Role = role,
            Content = new List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>
            {
                MessageContentImageFileObject.FromOpenAIFile(file, detail),
            },
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <param name="role"></param>
    /// <returns></returns>
    public static CreateMessageRequest FromString(
        string content,
        CreateMessageRequestRole role = CreateMessageRequestRole.User)
    {
        return new CreateMessageRequest
        {
            Role = role,
            Content = content,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <param name="detail"></param>
    /// <param name="role"></param>
    /// <returns></returns>
    public static CreateMessageRequest FromUri(
        Uri uri,
        MessageContentImageUrlObjectImageUrlDetail detail = MessageContentImageUrlObjectImageUrlDetail.Auto,
        CreateMessageRequestRole role = CreateMessageRequestRole.User)
    {
        uri = uri ?? throw new ArgumentNullException(nameof(uri));
        
        return new CreateMessageRequest
        {
            Role = role,
            Content = new List<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MessageContentImageFileObject, global::tryAGI.OpenAI.MessageContentImageUrlObject, global::tryAGI.OpenAI.MessageRequestContentTextObject>>
            {
                MessageContentImageUrlObject.FromUri(uri, detail),
            },
        };
    }
}