#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create a remix of a completed video using a refreshed prompt.
        /// </summary>
        /// <param name="videoId">
        /// Example: video_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> CreateVideoRemixAsync(
            string videoId,

            global::tryAGI.OpenAI.CreateVideoRemixBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a remix of a completed video using a refreshed prompt.
        /// </summary>
        /// <param name="videoId">
        /// Example: video_123
        /// </param>
        /// <param name="prompt">
        /// Updated text prompt that directs the remix generation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> CreateVideoRemixAsync(
            string videoId,
            string prompt,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}