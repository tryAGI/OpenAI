#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Fetch the latest metadata for a generated video.
        /// </summary>
        /// <param name="videoId">
        /// Example: video_123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> RetrieveVideoAsync(
            string videoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}