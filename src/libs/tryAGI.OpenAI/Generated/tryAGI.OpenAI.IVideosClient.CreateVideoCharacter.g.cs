#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create a character from an uploaded video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoCharacterResource> CreateVideoCharacterAsync(

            global::tryAGI.OpenAI.CreateVideoCharacterBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a character from an uploaded video.
        /// </summary>
        /// <param name="video">
        /// Video file used to create a character.
        /// </param>
        /// <param name="videoname">
        /// Video file used to create a character.
        /// </param>
        /// <param name="name">
        /// Display name for this API character.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoCharacterResource> CreateVideoCharacterAsync(
            byte[] video,
            string videoname,
            string name,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}