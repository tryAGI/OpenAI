#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List all organization and project API keys.<br/>
        /// List organization API keys
        /// </summary>
        /// <param name="after">
        /// Return keys with IDs that come after this ID in the pagination order.
        /// </param>
        /// <param name="order">
        /// Order results by creation time, ascending or descending.<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="limit">
        /// Maximum number of keys to return.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ApiKeyList> AdminApiKeysListAsync(
            string? after = default,
            global::tryAGI.OpenAI.AdminApiKeysListOrder? order = default,
            int? limit = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all organization and project API keys.<br/>
        /// List organization API keys
        /// </summary>
        /// <param name="after">
        /// Return keys with IDs that come after this ID in the pagination order.
        /// </param>
        /// <param name="order">
        /// Order results by creation time, ascending or descending.<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="limit">
        /// Maximum number of keys to return.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ApiKeyList>> AdminApiKeysListAsResponseAsync(
            string? after = default,
            global::tryAGI.OpenAI.AdminApiKeysListOrder? order = default,
            int? limit = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AdminApiKeysListAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.AdminApiKey&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="order">
        /// Order results by creation time, ascending or descending.<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="limit">
        /// Maximum number of keys to return.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.AdminApiKey> AdminApiKeysListAutoPagingAsync(
              global::tryAGI.OpenAI.AdminApiKeysListOrder? order = default,
            int? limit = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}