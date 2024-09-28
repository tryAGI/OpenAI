namespace OpenAI;

public partial class MessageContentImageUrlObject
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static implicit operator MessageContentImageUrlObject(Uri uri)
    {
        return FromUri(uri);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <param name="detail"></param>
    /// <returns></returns>
    public static MessageContentImageUrlObject FromUri(
        Uri uri,
        MessageContentImageUrlObjectImageUrlDetail detail = MessageContentImageUrlObjectImageUrlDetail.Auto)
    {
        uri = uri ?? throw new ArgumentNullException(nameof(uri));
        
        return new MessageContentImageUrlObject
        {
            ImageUrl = new MessageContentImageUrlObjectImageUrl
            {
                Detail = detail,
                Url = uri.ToString(),
            }
        };
    }
}