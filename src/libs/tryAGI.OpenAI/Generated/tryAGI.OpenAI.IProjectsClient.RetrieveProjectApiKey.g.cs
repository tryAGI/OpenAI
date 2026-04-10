#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieves an API key in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectApiKey> RetrieveProjectApiKeyAsync(
            string projectId,
            string keyId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}