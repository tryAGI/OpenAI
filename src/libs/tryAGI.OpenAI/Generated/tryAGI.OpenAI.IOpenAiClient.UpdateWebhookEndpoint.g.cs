#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Update Webhook Endpoint<br/>
        /// Updates a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointBody> UpdateWebhookEndpointAsync(
            string webhookEndpointId,

            global::tryAGI.OpenAI.PublicUpdateEndpointBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Webhook Endpoint<br/>
        /// Updates a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.WebhookEndpointBody>> UpdateWebhookEndpointAsResponseAsync(
            string webhookEndpointId,

            global::tryAGI.OpenAI.PublicUpdateEndpointBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Webhook Endpoint<br/>
        /// Updates a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="name">
        /// A new human-readable name for the webhook endpoint.
        /// </param>
        /// <param name="url">
        /// A new HTTPS URL that receives webhook deliveries.
        /// </param>
        /// <param name="eventTypes">
        /// The complete set of event types that should trigger deliveries.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointBody> UpdateWebhookEndpointAsync(
            string webhookEndpointId,
            string? name = default,
            string? url = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>? eventTypes = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}