#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List agent environment files<br/>
        /// Lists live files on a connected execution environment with optional directory filtering and opaque cursor pagination. See [environment files](https://developers.openai.com/api/docs/guides/agents-api/environments/files).
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="path"></param>
        /// <param name="limit"></param>
        /// <param name="order">
        /// The order in which paginated resources are returned.
        /// </param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EnvironmentFileListResource> ListAgentEnvironmentFilesAsync(
            string environmentId,
            string? path = default,
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? page = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent environment files<br/>
        /// Lists live files on a connected execution environment with optional directory filtering and opaque cursor pagination. See [environment files](https://developers.openai.com/api/docs/guides/agents-api/environments/files).
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="path"></param>
        /// <param name="limit"></param>
        /// <param name="order">
        /// The order in which paginated resources are returned.
        /// </param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.EnvironmentFileListResource>> ListAgentEnvironmentFilesAsResponseAsync(
            string environmentId,
            string? path = default,
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? page = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}