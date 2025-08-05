#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List project rate limits<br/>
        /// Returns the rate limits per model for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectRateLimitListResponse> ListProjectRateLimitsAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}