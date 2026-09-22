#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List external storage configurations<br/>
        /// List the organization's customer-managed external storage configurations.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="after"></param>
        /// <param name="order"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ExternalStorageListResource> ListexternalstorageconfigurationsAsync(
            string? projectId = default,
            string? after = default,
            global::tryAGI.OpenAI.ExternalStorageOrder? order = default,
            int? limit = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List external storage configurations<br/>
        /// List the organization's customer-managed external storage configurations.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="after"></param>
        /// <param name="order"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ExternalStorageListResource>> ListexternalstorageconfigurationsAsResponseAsync(
            string? projectId = default,
            string? after = default,
            global::tryAGI.OpenAI.ExternalStorageOrder? order = default,
            int? limit = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListexternalstorageconfigurationsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.ExternalStorageResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="order"></param>
        /// <param name="limit"></param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.ExternalStorageResponse> ListexternalstorageconfigurationsAutoPagingAsync(
              string? projectId = default,
            global::tryAGI.OpenAI.ExternalStorageOrder? order = default,
            int? limit = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}