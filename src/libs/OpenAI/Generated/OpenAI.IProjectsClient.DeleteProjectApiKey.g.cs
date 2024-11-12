#nullable enable

namespace OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Deletes an API key from the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ProjectApiKeyDeleteResponse> DeleteProjectApiKeyAsync(
            string projectId,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}