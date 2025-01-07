#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Delete an organization admin API key<br/>
        /// Delete the specified admin API key.
        /// </summary>
        /// <param name="keyId">
        /// The ID of the API key to be deleted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AdminApiKeysDeleteResponse> AdminApiKeysDeleteAsync(
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}