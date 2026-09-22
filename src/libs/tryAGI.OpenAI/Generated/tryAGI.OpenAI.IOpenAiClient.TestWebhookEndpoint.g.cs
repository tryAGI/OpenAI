#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Test Webhook Endpoint<br/>
        /// Sends a sample event to a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointTestResultResource> TestWebhookEndpointAsync(
            string webhookEndpointId,

            global::tryAGI.OpenAI.PublicTestEndpointBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Webhook Endpoint<br/>
        /// Sends a sample event to a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.WebhookEndpointTestResultResource>> TestWebhookEndpointAsResponseAsync(
            string webhookEndpointId,

            global::tryAGI.OpenAI.PublicTestEndpointBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Webhook Endpoint<br/>
        /// Sends a sample event to a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="eventType">
        /// The event type to send as a sample delivery.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointTestResultResource> TestWebhookEndpointAsync(
            string webhookEndpointId,
            global::tryAGI.OpenAI.ProjectEventTypeEnum eventType,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}