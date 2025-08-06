#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve admin API key<br/>
        /// Retrieve a single organization API key
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