#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an automation<br/>
        /// Updates supplied fields; target and metadata replace the whole field.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutomationResource> UpdateAgentAutomationAsync(
            string automationId,

            global::tryAGI.OpenAI.UpdateAutomationParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an automation<br/>
        /// Updates supplied fields; target and metadata replace the whole field.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.AutomationResource>> UpdateAgentAutomationAsResponseAsync(
            string automationId,

            global::tryAGI.OpenAI.UpdateAutomationParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an automation<br/>
        /// Updates supplied fields; target and metadata replace the whole field.
        /// </summary>
        /// <param name="automationId"></param>
        /// <param name="name"></param>
        /// <param name="target">
        /// Replaces the complete target, retaining its type and any creator session.
        /// </param>
        /// <param name="metadata">
        /// Replaces all metadata; omit to leave unchanged.
        /// </param>
        /// <param name="expression">
        /// Only accepted for periodic automations.
        /// </param>
        /// <param name="timezone">
        /// Only accepted for periodic automations.
        /// </param>
        /// <param name="runAt">
        /// A future Unix timestamp in seconds; accepted only before a one-time scheduled invocation exists.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutomationResource> UpdateAgentAutomationAsync(
            string automationId,
            string? name = default,
            global::tryAGI.OpenAI.AutomationTargetParam? target = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? expression = default,
            string? timezone = default,
            global::System.DateTimeOffset? runAt = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}