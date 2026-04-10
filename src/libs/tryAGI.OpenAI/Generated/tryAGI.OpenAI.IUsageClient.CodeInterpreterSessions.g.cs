#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get code interpreter sessions usage details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UsageResponse> CodeInterpreterSessionsAsync(
            int startTime,
            int? endTime = default,
            global::tryAGI.OpenAI.UsageCodeInterpreterSessionsBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.UsageCodeInterpreterSessionsGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}