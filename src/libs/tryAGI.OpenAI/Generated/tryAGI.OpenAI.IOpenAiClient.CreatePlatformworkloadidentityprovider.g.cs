#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create Platform workload identity provider<br/>
        /// Register an OIDC provider for keyless project service-account authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PlatformProvider> CreatePlatformworkloadidentityproviderAsync(

            global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Platform workload identity provider<br/>
        /// Register an OIDC provider for keyless project service-account authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.PlatformProvider>> CreatePlatformworkloadidentityproviderAsResponseAsync(

            global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Platform workload identity provider<br/>
        /// Register an OIDC provider for keyless project service-account authentication.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: oidc
        /// </param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="verification"></param>
        /// <param name="description"></param>
        /// <param name="attributeTransformations"></param>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PlatformProvider> CreatePlatformworkloadidentityproviderAsync(
            string name,
            string issuer,
            string audience,
            global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType type = global::tryAGI.OpenAI.CreatePlatformWorkloadIdentityProviderBodyType.Oidc,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.DiscoveryVerificationParam, global::tryAGI.OpenAI.UploadedJwksVerificationParam>? verification = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TransformationParam>? attributeTransformations = default,
            bool? enabled = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}