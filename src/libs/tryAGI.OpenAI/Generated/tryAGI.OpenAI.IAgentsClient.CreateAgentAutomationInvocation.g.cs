#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Invoke an automation<br/>
        /// Queues a manual delivery without changing the saved schedule.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutomationInvocationResource> CreateAgentAutomationInvocationAsync(
            string automationId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invoke an automation<br/>
        /// Queues a manual delivery without changing the saved schedule.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.AutomationInvocationResource>> CreateAgentAutomationInvocationAsResponseAsync(
            string automationId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}