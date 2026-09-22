#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create Webhook Endpoint<br/>
        /// Creates a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointWithSecretResource> CreateWebhookEndpointAsync(

            global::tryAGI.OpenAI.PublicCreateEndpointBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Webhook Endpoint<br/>
        /// Creates a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.WebhookEndpointWithSecretResource>> CreateWebhookEndpointAsResponseAsync(

            global::tryAGI.OpenAI.PublicCreateEndpointBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Webhook Endpoint<br/>
        /// Creates a webhook endpoint for the authenticated project.
        /// </summary>
        /// <param name="name">
        /// A human-readable name for the webhook endpoint.
        /// </param>
        /// <param name="url">
        /// The HTTPS URL that receives webhook deliveries.
        /// </param>
        /// <param name="eventTypes">
        /// The event types that trigger deliveries to this endpoint.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointWithSecretResource> CreateWebhookEndpointAsync(
            string name,
            string url,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum> eventTypes,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}