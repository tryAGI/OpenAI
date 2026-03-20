#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create a new video generation job by editing a source video or existing generated video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> CreateVideoEditAsync(

            global::tryAGI.OpenAI.CreateVideoEditMultipartBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new video generation job by editing a source video or existing generated video.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="prompt">
        /// Text prompt that describes how to edit the source video.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> CreateVideoEditAsync(
            global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam> video,
            string prompt,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}