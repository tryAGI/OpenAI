#nullable enable

namespace OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Deletes a service account from the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ProjectServiceAccountDeleteResponse> DeleteProjectServiceAccountAsync(
            string projectId,
            string serviceAccountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}