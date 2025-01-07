#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve a single organization API key<br/>
        /// Get details for a specific organization API key by its ID.
        /// </summary>
        /// <param name="keyId">
        /// The ID of the API key.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AdminApiKey> AdminApiKeysGetAsync(
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}