#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVaultsClient
    {
        /// <summary>
        /// Delete a vault<br/>
        /// Deletes a vault and all its credentials. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="vaultId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeletedVaultResource> DeleteVaultAsync(
            string vaultId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a vault<br/>
        /// Deletes a vault and all its credentials. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="vaultId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.DeletedVaultResource>> DeleteVaultAsResponseAsync(
            string vaultId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}