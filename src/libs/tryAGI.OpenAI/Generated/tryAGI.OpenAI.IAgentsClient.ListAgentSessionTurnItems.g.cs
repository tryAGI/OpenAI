#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List agent session turn items<br/>
        /// Lists items belonging to one root-agent turn, including its interactions with subagents. See [inspecting agent output](https://developers.openai.com/api/docs/guides/agents-api/observability).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="turnId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SessionItemListResource> ListAgentSessionTurnItemsAsync(
            string sessionId,
            string turnId,
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent session turn items<br/>
        /// Lists items belonging to one root-agent turn, including its interactions with subagents. See [inspecting agent output](https://developers.openai.com/api/docs/guides/agents-api/observability).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="turnId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.SessionItemListResource>> ListAgentSessionTurnItemsAsResponseAsync(
            string sessionId,
            string turnId,
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAgentSessionTurnItemsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.SessionTurnItemResource&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="turnId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.SessionTurnItemResource> ListAgentSessionTurnItemsAutoPagingAsync(
            string sessionId,
            string turnId,             long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}