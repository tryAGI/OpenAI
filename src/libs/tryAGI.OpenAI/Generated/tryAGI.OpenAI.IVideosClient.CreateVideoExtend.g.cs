#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create an extension of a completed video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> CreateVideoExtendAsync(

            global::tryAGI.OpenAI.CreateVideoExtendMultipartBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an extension of a completed video.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="prompt">
        /// Updated text prompt that directs the extension generation.
        /// </param>
        /// <param name="seconds">
        /// Length of the newly generated extension segment in seconds (allowed values: 4, 8, 12, 16, 20).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> CreateVideoExtendAsync(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]> video,
            string prompt,
            global::tryAGI.OpenAI.VideoSeconds seconds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}