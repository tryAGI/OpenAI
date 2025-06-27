#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Updates a project rate limit.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rateLimitId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectRateLimit> UpdateProjectRateLimitsAsync(
            string projectId,
            string rateLimitId,
            global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a project rate limit.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rateLimitId"></param>
        /// <param name="batch1DayMaxInputTokens">
        /// The maximum batch input tokens per day. Only relevant for certain models.
        /// </param>
        /// <param name="maxAudioMegabytesPer1Minute">
        /// The maximum audio megabytes per minute. Only relevant for certain models.
        /// </param>
        /// <param name="maxImagesPer1Minute">
        /// The maximum images per minute. Only relevant for certain models.
        /// </param>
        /// <param name="maxRequestsPer1Day">
        /// The maximum requests per day. Only relevant for certain models.
        /// </param>
        /// <param name="maxRequestsPer1Minute">
        /// The maximum requests per minute.
        /// </param>
        /// <param name="maxTokensPer1Minute">
        /// The maximum tokens per minute.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectRateLimit> UpdateProjectRateLimitsAsync(
            string projectId,
            string rateLimitId,
            int? batch1DayMaxInputTokens = default,
            int? maxAudioMegabytesPer1Minute = default,
            int? maxImagesPer1Minute = default,
            int? maxRequestsPer1Day = default,
            int? maxRequestsPer1Minute = default,
            int? maxTokensPer1Minute = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}