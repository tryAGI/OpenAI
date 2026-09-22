#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List agent sessions<br/>
        /// Lists managed agent sessions using ID-based pagination and the requested sort order. See [managing sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions/manage).
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SessionListResource> ListAgentSessionsAsync(
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? agentId = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent sessions<br/>
        /// Lists managed agent sessions using ID-based pagination and the requested sort order. See [managing sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions/manage).
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.SessionListResource>> ListAgentSessionsAsResponseAsync(
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? agentId = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAgentSessionsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.SessionResource&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.SessionResource> ListAgentSessionsAutoPagingAsync(
              long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? agentId = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}