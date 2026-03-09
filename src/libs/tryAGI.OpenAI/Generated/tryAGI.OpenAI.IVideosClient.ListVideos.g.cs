#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// List recently generated videos for the current project.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after">
        /// Identifier for the last item from the previous pagination request
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoListResource> ListVideosAsync(
            int? limit = default,
            global::tryAGI.OpenAI.OrderEnum? order = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}