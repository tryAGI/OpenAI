#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve Platform workload identity federation rule<br/>
        /// Retrieve a federation rule owned by the authenticated organization and provider.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="workloadIdentityFederationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PlatformFederationRule> RetrievePlatformworkloadidentityfederationruleAsync(
            string workloadIdentityProviderId,
            string workloadIdentityFederationRuleId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Platform workload identity federation rule<br/>
        /// Retrieve a federation rule owned by the authenticated organization and provider.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="workloadIdentityFederationRuleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.PlatformFederationRule>> RetrievePlatformworkloadidentityfederationruleAsResponseAsync(
            string workloadIdentityProviderId,
            string workloadIdentityFederationRuleId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}