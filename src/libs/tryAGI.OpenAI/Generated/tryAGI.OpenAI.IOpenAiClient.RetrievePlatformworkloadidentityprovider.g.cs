#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve Platform workload identity provider<br/>
        /// Retrieve an OIDC provider in the authenticated organization.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PlatformProvider> RetrievePlatformworkloadidentityproviderAsync(
            string workloadIdentityProviderId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Platform workload identity provider<br/>
        /// Retrieve an OIDC provider in the authenticated organization.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.PlatformProvider>> RetrievePlatformworkloadidentityproviderAsResponseAsync(
            string workloadIdentityProviderId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}