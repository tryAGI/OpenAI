#if !NET6_0_OR_GREATER
namespace OpenAI;

/// <summary>
/// 
/// </summary>
public static class Polyfills
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<string> ReadAsStringAsync(
        this global::System.Net.Http.HttpContent content,
        global::System.Threading.CancellationToken cancellationToken)
    {
        content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        
        return content.ReadAsStringAsync();
    }
}
#endif