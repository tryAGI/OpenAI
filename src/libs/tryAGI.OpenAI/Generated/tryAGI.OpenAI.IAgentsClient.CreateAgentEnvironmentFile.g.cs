#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an agent environment file<br/>
        /// Copies inline bytes or a Files API file into a connected execution environment. See [environment files](https://developers.openai.com/api/docs/guides/agents-api/environments/files).
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EnvironmentFileResource> CreateAgentEnvironmentFileAsync(
            string environmentId,

            global::tryAGI.OpenAI.HostedEnvironmentFileParam request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent environment file<br/>
        /// Copies inline bytes or a Files API file into a connected execution environment. See [environment files](https://developers.openai.com/api/docs/guides/agents-api/environments/files).
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.EnvironmentFileResource>> CreateAgentEnvironmentFileAsResponseAsync(
            string environmentId,

            global::tryAGI.OpenAI.HostedEnvironmentFileParam request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}