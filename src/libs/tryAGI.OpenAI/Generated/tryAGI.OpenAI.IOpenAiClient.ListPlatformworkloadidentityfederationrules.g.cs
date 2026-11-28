#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List Platform workload identity federation rules<br/>
        /// List the provider's federation rules to project service accounts.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PlatformFederationRuleListResource> ListPlatformworkloadidentityfederationrulesAsync(
            string workloadIdentityProviderId,
            int? limit = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant2?>? order = default,
            string? after = default,
            string? serviceAccountId = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Platform workload identity federation rules<br/>
        /// List the provider's federation rules to project service accounts.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.PlatformFederationRuleListResource>> ListPlatformworkloadidentityfederationrulesAsResponseAsync(
            string workloadIdentityProviderId,
            int? limit = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant2?>? order = default,
            string? after = default,
            string? serviceAccountId = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListPlatformworkloadidentityfederationrulesAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.PlatformFederationRule&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.PlatformFederationRule> ListPlatformworkloadidentityfederationrulesAutoPagingAsync(
            string workloadIdentityProviderId,             int? limit = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant1?, global::tryAGI.OpenAI.ListPlatformworkloadidentityfederationrulesOrderVariant2?>? order = default,
            string? serviceAccountId = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}