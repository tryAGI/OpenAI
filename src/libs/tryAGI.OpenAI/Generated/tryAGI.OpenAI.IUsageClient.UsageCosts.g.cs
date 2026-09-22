#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Costs<br/>
        /// Get costs details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="lineItems"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UsageResponse> UsageCostsAsync(
            int startTime,
            int? endTime = default,
            global::tryAGI.OpenAI.UsageCostsBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? lineItems = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Costs<br/>
        /// Get costs details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="lineItems"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.UsageResponse>> UsageCostsAsResponseAsync(
            int startTime,
            int? endTime = default,
            global::tryAGI.OpenAI.UsageCostsBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? lineItems = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps UsageCostsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.UsageTimeBucket&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="lineItems"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.UsageTimeBucket> UsageCostsAutoPagingAsync(
            int startTime,             int? endTime = default,
            global::tryAGI.OpenAI.UsageCostsBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? lineItems = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCostsGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}