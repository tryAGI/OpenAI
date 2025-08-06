#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieve project API key<br/>
        /// Retrieves an API key in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectApiKey> RetrieveProjectApiKeyAsync(
            string projectId,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}