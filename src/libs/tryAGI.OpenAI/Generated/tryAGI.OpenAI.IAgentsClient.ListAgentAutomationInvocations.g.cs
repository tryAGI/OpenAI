#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List automation invocations<br/>
        /// Lists delivery records for a project-owned automation.
        /// </summary>
        /// <param name="automationId"></param>
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
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListAgentAutomationInvocationsResponse> ListAgentAutomationInvocationsAsync(
            string automationId,
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List automation invocations<br/>
        /// Lists delivery records for a project-owned automation.
        /// </summary>
        /// <param name="automationId"></param>
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
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ListAgentAutomationInvocationsResponse>> ListAgentAutomationInvocationsAsResponseAsync(
            string automationId,
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAgentAutomationInvocationsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.AutomationInvocationResource&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.AutomationInvocationResource> ListAgentAutomationInvocationsAutoPagingAsync(
            string automationId,             long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}