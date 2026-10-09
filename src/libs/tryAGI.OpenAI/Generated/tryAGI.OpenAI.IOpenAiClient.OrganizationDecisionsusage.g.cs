#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Decisions<br/>
        /// Get Decisions API usage details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="projectIds"></param>
        /// <param name="groupBy"></param>
        /// <param name="userIds"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="models"></param>
        /// <param name="batch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PublicDecisionsUsageResponseResource> OrganizationDecisionsusageAsync(
            int startTime,
            int? endTime = default,
            global::tryAGI.OpenAI.DecisionsUsageBucketWidth? bucketWidth = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? groupBy = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            bool? batch = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Decisions<br/>
        /// Get Decisions API usage details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="projectIds"></param>
        /// <param name="groupBy"></param>
        /// <param name="userIds"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="models"></param>
        /// <param name="batch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.PublicDecisionsUsageResponseResource>> OrganizationDecisionsusageAsResponseAsync(
            int startTime,
            int? endTime = default,
            global::tryAGI.OpenAI.DecisionsUsageBucketWidth? bucketWidth = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? groupBy = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            bool? batch = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps OrganizationDecisionsusageAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.DecisionsUsageBucket&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth"></param>
        /// <param name="limit"></param>
        /// <param name="projectIds"></param>
        /// <param name="groupBy"></param>
        /// <param name="userIds"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="models"></param>
        /// <param name="batch"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.DecisionsUsageBucket> OrganizationDecisionsusageAutoPagingAsync(
            int startTime,             int? endTime = default,
            global::tryAGI.OpenAI.DecisionsUsageBucketWidth? bucketWidth = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.DecisionsUsageGroupBy>? groupBy = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            bool? batch = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}