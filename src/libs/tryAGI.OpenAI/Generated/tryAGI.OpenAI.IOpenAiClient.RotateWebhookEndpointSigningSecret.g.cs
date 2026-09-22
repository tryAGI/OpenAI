#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Rotate Webhook Endpoint Signing Secret<br/>
        /// Rotates the signing secret for a webhook endpoint in the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointWithSecretResource> RotateWebhookEndpointSigningSecretAsync(
            string webhookEndpointId,

            global::tryAGI.OpenAI.PublicRotateSecretBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate Webhook Endpoint Signing Secret<br/>
        /// Rotates the signing secret for a webhook endpoint in the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.WebhookEndpointWithSecretResource>> RotateWebhookEndpointSigningSecretAsResponseAsync(
            string webhookEndpointId,

            global::tryAGI.OpenAI.PublicRotateSecretBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate Webhook Endpoint Signing Secret<br/>
        /// Rotates the signing secret for a webhook endpoint in the authenticated project.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// Example: whe_123
        /// </param>
        /// <param name="keepOldSecretActiveFor24Hours">
        /// Whether to keep the previous signing secret valid for 24 hours after rotation. Defaults to false, which invalidates the previous secret immediately.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointWithSecretResource> RotateWebhookEndpointSigningSecretAsync(
            string webhookEndpointId,
            bool? keepOldSecretActiveFor24Hours = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}