#nullable enable

namespace OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Creates a new service account in the project. This also returns an unredacted API key for the service account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ProjectServiceAccountCreateResponse> CreateProjectServiceAccountAsync(
            string projectId,
            global::OpenAI.ProjectServiceAccountCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new service account in the project. This also returns an unredacted API key for the service account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// The name of the service account being created.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ProjectServiceAccountCreateResponse> CreateProjectServiceAccountAsync(
            string projectId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}