#nullable enable

namespace OpenAI
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// Get images usage details for the organization.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="sources"></param>
        /// <param name="sizes"></param>
        /// <param name="projectIds"></param>
        /// <param name="userIds"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="models"></param>
        /// <param name="groupBy"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.UsageResponse> UsageImagesAsync(
            int startTime,
            int? endTime = default,
            global::OpenAI.UsageImagesBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<global::OpenAI.UsageImagesSource>? sources = default,
            global::System.Collections.Generic.IList<global::OpenAI.UsageImagesSize>? sizes = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::OpenAI.UsageImagesGroupByItem>? groupBy = default,
            int? limit = default,
            string? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}