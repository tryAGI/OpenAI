#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete project API key<br/>
        /// Deletes an API key from the project, including keys owned by service accounts.<br/>
        /// Requires permission to write project API keys. Deleting a service-account key<br/>
        /// does not delete the service account or its other keys.<br/>
        /// Returns confirmation of the key deletion.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse> DeleteProjectApiKeyAsync(
            string projectId,
            string apiKeyId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete project API key<br/>
        /// Deletes an API key from the project, including keys owned by service accounts.<br/>
        /// Requires permission to write project API keys. Deleting a service-account key<br/>
        /// does not delete the service account or its other keys.<br/>
        /// Returns confirmation of the key deletion.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectApiKeyDeleteResponse>> DeleteProjectApiKeyAsResponseAsync(
            string projectId,
            string apiKeyId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}