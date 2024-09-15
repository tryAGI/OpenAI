#nullable enable

namespace OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieves an API key in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ProjectApiKey> RetrieveProjectApiKeyAsync(
            string projectId,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}