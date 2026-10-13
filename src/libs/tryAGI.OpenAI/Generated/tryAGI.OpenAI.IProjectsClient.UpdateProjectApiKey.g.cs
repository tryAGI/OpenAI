#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update project API key<br/>
        /// Updates the expiration of an existing API key in the project, including a<br/>
        /// service-account-owned key. Requires permission to write project API keys.<br/>
        /// Provide `expires_in_seconds` to set the expiration relative to this request.<br/>
        /// The value must satisfy the organization's and project's expiry policies.<br/>
        /// Expired keys cannot be updated. Retrying resets the expiration relative to<br/>
        /// the new request. The response contains only the redacted key, not its secret.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectApiKey> UpdateProjectApiKeyAsync(
            string projectId,
            string apiKeyId,

            global::tryAGI.OpenAI.UpdateProjectApiKeyBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project API key<br/>
        /// Updates the expiration of an existing API key in the project, including a<br/>
        /// service-account-owned key. Requires permission to write project API keys.<br/>
        /// Provide `expires_in_seconds` to set the expiration relative to this request.<br/>
        /// The value must satisfy the organization's and project's expiry policies.<br/>
        /// Expired keys cannot be updated. Retrying resets the expiration relative to<br/>
        /// the new request. The response contains only the redacted key, not its secret.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectApiKey>> UpdateProjectApiKeyAsResponseAsync(
            string projectId,
            string apiKeyId,

            global::tryAGI.OpenAI.UpdateProjectApiKeyBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project API key<br/>
        /// Updates the expiration of an existing API key in the project, including a<br/>
        /// service-account-owned key. Requires permission to write project API keys.<br/>
        /// Provide `expires_in_seconds` to set the expiration relative to this request.<br/>
        /// The value must satisfy the organization's and project's expiry policies.<br/>
        /// Expired keys cannot be updated. Retrying resets the expiration relative to<br/>
        /// the new request. The response contains only the redacted key, not its secret.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="expiresInSeconds">
        /// Number of seconds from this request until the API key expires. Must comply with the organization and project expiry policies. Expired keys cannot be updated. Retrying resets the expiry relative to the new request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectApiKey> UpdateProjectApiKeyAsync(
            string projectId,
            string apiKeyId,
            int expiresInSeconds,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}