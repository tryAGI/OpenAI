#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVaultsClient
    {
        /// <summary>
        /// Rotate a vault credential<br/>
        /// Rotates a vault credential's write-only secret and returns only credential metadata. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="vaultId"></param>
        /// <param name="credentialId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VaultCredentialResource> RotateVaultCredentialAsync(
            string vaultId,
            string credentialId,

            global::tryAGI.OpenAI.RotateVaultCredentialParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a vault credential<br/>
        /// Rotates a vault credential's write-only secret and returns only credential metadata. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="vaultId"></param>
        /// <param name="credentialId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.VaultCredentialResource>> RotateVaultCredentialAsResponseAsync(
            string vaultId,
            string credentialId,

            global::tryAGI.OpenAI.RotateVaultCredentialParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a vault credential<br/>
        /// Rotates a vault credential's write-only secret and returns only credential metadata. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="vaultId"></param>
        /// <param name="credentialId"></param>
        /// <param name="auth">
        /// Replacement values for the credential's existing authentication method.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VaultCredentialResource> RotateVaultCredentialAsync(
            string vaultId,
            string credentialId,
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParam auth,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}