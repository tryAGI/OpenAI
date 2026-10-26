#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Resume an automation<br/>
        /// Resumes scheduled delivery; one-time automations without a pending invocation require a future run_at.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutomationResource> ResumeAgentAutomationAsync(
            string automationId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume an automation<br/>
        /// Resumes scheduled delivery; one-time automations without a pending invocation require a future run_at.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.AutomationResource>> ResumeAgentAutomationAsResponseAsync(
            string automationId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}