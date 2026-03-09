#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create a new video generation job from a prompt and optional reference assets.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> CreateVideoAsync(

            global::tryAGI.OpenAI.CreateVideoBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new video generation job from a prompt and optional reference assets.
        /// </summary>
        /// <param name="model">
        /// The video generation model to use (allowed values: sora-2, sora-2-pro). Defaults to `sora-2`.
        /// </param>
        /// <param name="prompt">
        /// Text prompt that describes the video to generate.
        /// </param>
        /// <param name="inputReference">
        /// Optional multipart reference asset that guides generation.
        /// </param>
        /// <param name="inputReferencename">
        /// Optional multipart reference asset that guides generation.
        /// </param>
        /// <param name="imageReference">
        /// Optional JSON-safe image reference that guides generation. Provide exactly one of `image_url` or `file_id`.
        /// </param>
        /// <param name="seconds">
        /// Clip duration in seconds (allowed values: 4, 8, 12). Defaults to 4 seconds.
        /// </param>
        /// <param name="size">
        /// Output resolution formatted as width x height (allowed values: 720x1280, 1280x720, 1024x1792, 1792x1024). Defaults to 720x1280.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoResource> CreateVideoAsync(
            string prompt,
            global::tryAGI.OpenAI.VideoModel? model = default,
            byte[]? inputReference = default,
            string? inputReferencename = default,
            global::tryAGI.OpenAI.ImageRefParam2? imageReference = default,
            global::tryAGI.OpenAI.VideoSeconds? seconds = default,
            global::tryAGI.OpenAI.VideoSize? size = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}