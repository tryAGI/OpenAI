namespace OpenAI;

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
    /// <param name="file"></param>
    /// <param name="role"></param>
    /// <param name="detail"></param>
    /// <returns></returns>
    public static CreateMessageRequest FromOpenAIFile(
        OpenAIFile file,
        CreateMessageRequestRole role = CreateMessageRequestRole.User,
        MessageContentImageFileObjectImageFileDetail? detail = null)
    {
        file = file ?? throw new ArgumentNullException(nameof(file));

        return new CreateMessageRequest
        {
            Role = CreateMessageRequestRole.User,
            Content = new List<OneOf<MessageContentImageFileObject, MessageContentImageUrlObject,
                    MessageRequestContentTextObject>>
                {
                    MessageContentImageFileObject.FromOpenAIFile(file),
                },
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static CreateMessageRequest FromString(string content)
    {
        return new CreateMessageRequest
        {
            Role = CreateMessageRequestRole.User,
            Content = content,
        };
    }
}