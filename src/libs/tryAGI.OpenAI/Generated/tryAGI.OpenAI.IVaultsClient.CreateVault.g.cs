#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVaultsClient
    {
        /// <summary>
        /// Create a vault<br/>
        /// Creates a vault for the current project. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VaultResource> CreateVaultAsync(

            global::tryAGI.OpenAI.CreateVaultParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a vault<br/>
        /// Creates a vault for the current project. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.VaultResource>> CreateVaultAsResponseAsync(

            global::tryAGI.OpenAI.CreateVaultParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a vault<br/>
        /// Creates a vault for the current project. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="name">
        /// The name is trimmed before storage. It must contain 1 to 256 UTF-8 bytes after trimming.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to associate with the vault, such as an application or team identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VaultResource> CreateVaultAsync(
            string? name = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}