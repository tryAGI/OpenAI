#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Update Platform workload identity federation rule<br/>
        /// Update supplied matcher, permission, metadata, or enabled fields.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="workloadIdentityFederationRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PlatformFederationRule> UpdatePlatformworkloadidentityfederationruleAsync(
            string workloadIdentityProviderId,
            string workloadIdentityFederationRuleId,

            global::tryAGI.OpenAI.UpdatePlatformWorkloadIdentityFederationRuleBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Platform workload identity federation rule<br/>
        /// Update supplied matcher, permission, metadata, or enabled fields.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="workloadIdentityFederationRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.PlatformFederationRule>> UpdatePlatformworkloadidentityfederationruleAsResponseAsync(
            string workloadIdentityProviderId,
            string workloadIdentityFederationRuleId,

            global::tryAGI.OpenAI.UpdatePlatformWorkloadIdentityFederationRuleBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Platform workload identity federation rule<br/>
        /// Update supplied matcher, permission, metadata, or enabled fields.
        /// </summary>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="workloadIdentityFederationRuleId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="attributeMatchers"></param>
        /// <param name="permissions"></param>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PlatformFederationRule> UpdatePlatformworkloadidentityfederationruleAsync(
            string workloadIdentityProviderId,
            string workloadIdentityFederationRuleId,
            string? name = default,
            string? description = default,
            object? attributeMatchers = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DefaultPermissionsParam, global::tryAGI.OpenAI.RestrictedPermissionsParam>? permissions = default,
            bool? enabled = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}