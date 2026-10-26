#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List automations<br/>
        /// Lists project-owned automations, optionally filtered by target session.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListAgentAutomationsResponse> ListAgentAutomationsAsync(
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = default,
            string? sessionId = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List automations<br/>
        /// Lists project-owned automations, optionally filtered by target session.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ListAgentAutomationsResponse>> ListAgentAutomationsAsResponseAsync(
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = default,
            string? sessionId = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAgentAutomationsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.AutomationResource&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.AutomationResource> ListAgentAutomationsAutoPagingAsync(
              long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? sessionId = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}