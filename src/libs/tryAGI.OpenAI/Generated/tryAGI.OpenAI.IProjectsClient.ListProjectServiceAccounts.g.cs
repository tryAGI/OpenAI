#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List project service accounts<br/>
        /// Returns a list of service accounts in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectServiceAccountListResponse> ListProjectServiceAccountsAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}