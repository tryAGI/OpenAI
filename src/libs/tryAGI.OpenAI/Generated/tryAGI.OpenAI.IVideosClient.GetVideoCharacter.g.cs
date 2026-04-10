#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Fetch a character.
        /// </summary>
        /// <param name="characterId">
        /// Example: char_123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VideoCharacterResource> GetVideoCharacterAsync(
            string characterId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}