#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISpendAlertsClient
    {
        /// <summary>
        /// Lists project spend alerts.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectSpendAlertListResource> ListProjectSpendAlertsAsync(
            string projectId,
            int? limit = default,
            global::tryAGI.OpenAI.ListProjectSpendAlertsOrder? order = default,
            string? after = default,
            string? before = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists project spend alerts.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectSpendAlertListResource>> ListProjectSpendAlertsAsResponseAsync(
            string projectId,
            int? limit = default,
            global::tryAGI.OpenAI.ListProjectSpendAlertsOrder? order = default,
            string? after = default,
            string? before = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListProjectSpendAlertsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.ProjectSpendAlert&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="before"></param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.ProjectSpendAlert> ListProjectSpendAlertsAutoPagingAsync(
            string projectId,             int? limit = default,
            global::tryAGI.OpenAI.ListProjectSpendAlertsOrder? order = default,
            string? before = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}