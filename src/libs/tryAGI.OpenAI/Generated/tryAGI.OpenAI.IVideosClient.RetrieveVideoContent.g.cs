#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Download the generated video bytes or a derived preview asset.<br/>
        /// Streams the rendered video content for the specified video job.
        /// </summary>
        /// <param name="videoId">
        /// Example: video_123
        /// </param>
        /// <param name="variant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RetrieveVideoContentAsync(
            string videoId,
            global::tryAGI.OpenAI.VideoContentVariant? variant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}