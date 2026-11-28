#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List Platform workload identity providers<br/>
        /// List OIDC providers in the authenticated Admin API key's organization.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PlatformProviderListResource> ListPlatformworkloadidentityprovidersAsync(
            int? limit = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant2?>? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Platform workload identity providers<br/>
        /// List OIDC providers in the authenticated Admin API key's organization.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.PlatformProviderListResource>> ListPlatformworkloadidentityprovidersAsResponseAsync(
            int? limit = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant2?>? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListPlatformworkloadidentityprovidersAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.PlatformProvider&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.PlatformProvider> ListPlatformworkloadidentityprovidersAutoPagingAsync(
              int? limit = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityprovidersOrderVariant2?>? order = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}