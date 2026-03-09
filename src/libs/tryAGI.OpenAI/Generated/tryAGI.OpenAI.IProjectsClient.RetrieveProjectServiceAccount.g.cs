#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieves a service account in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectServiceAccount> RetrieveProjectServiceAccountAsync(
            string projectId,
            string serviceAccountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}