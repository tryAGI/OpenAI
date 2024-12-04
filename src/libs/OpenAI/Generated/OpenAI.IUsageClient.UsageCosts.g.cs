#nullable enable

namespace OpenAI
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get costs details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.UsageResponse> UsageCostsAsync(
            int startTime,
            int? endTime = default,
            global::OpenAI.UsageCostsBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::OpenAI.UsageCostsGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}