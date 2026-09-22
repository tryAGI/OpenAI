#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List Webhook Endpoints<br/>
        /// Returns webhook endpoints for the authenticated project in newest-first order.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.WebhookEndpointListResource> ListWebhookEndpointsAsync(
            int? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Webhook Endpoints<br/>
        /// Returns webhook endpoints for the authenticated project in newest-first order.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.WebhookEndpointListResource>> ListWebhookEndpointsAsResponseAsync(
            int? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListWebhookEndpointsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.WebhookEndpointBody&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.WebhookEndpointBody> ListWebhookEndpointsAutoPagingAsync(
              int? limit = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}