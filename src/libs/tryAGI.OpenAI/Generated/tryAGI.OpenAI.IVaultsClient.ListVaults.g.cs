#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVaultsClient
    {
        /// <summary>
        /// List vaults<br/>
        /// Lists vaults using ID-based pagination. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit"></param>
        /// <param name="status">
        /// One or more lifecycle statuses to include when listing vaults or credentials.
        /// </param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VaultListResource> ListVaultsAsync(
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            long? limit = default,
            global::tryAGI.OpenAI.VaultStatusFilterParam? status = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List vaults<br/>
        /// Lists vaults using ID-based pagination. See [vaults](https://developers.openai.com/api/docs/guides/agents-api/tools/vaults).
        /// </summary>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit"></param>
        /// <param name="status">
        /// One or more lifecycle statuses to include when listing vaults or credentials.
        /// </param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.VaultListResource>> ListVaultsAsResponseAsync(
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            long? limit = default,
            global::tryAGI.OpenAI.VaultStatusFilterParam? status = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListVaultsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.VaultResource&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit"></param>
        /// <param name="status">
        /// One or more lifecycle statuses to include when listing vaults or credentials.
        /// </param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.VaultResource> ListVaultsAutoPagingAsync(
              global::tryAGI.OpenAI.ListOrderParam? order = default,
            long? limit = default,
            global::tryAGI.OpenAI.VaultStatusFilterParam? status = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}