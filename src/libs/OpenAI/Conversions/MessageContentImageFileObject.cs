namespace OpenAI;

public partial class MessageContentImageFileObject
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public static implicit operator MessageContentImageFileObject(OpenAIFile file)
    {
        return FromOpenAIFile(file);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="file"></param>
    /// <param name="detail"></param>
    /// <returns></returns>
    public static MessageContentImageFileObject FromOpenAIFile(
        OpenAIFile file,
        MessageContentImageFileObjectImageFileDetail? detail = null)
    {
        file = file ?? throw new ArgumentNullException(nameof(file));
        
        return new MessageContentImageFileObject
        {
            ImageFile = new MessageContentImageFileObjectImageFile
            {
                FileId = file.Id,
                Detail = detail,
            },
        };
    }
}