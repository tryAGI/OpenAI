#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Deactivate certificates at the organization level.<br/>
        /// You can atomically and idempotently deactivate up to 10 certificates at a time.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListCertificatesResponse> DeactivateCertificatesForOrganizationAsync(

            global::tryAGI.OpenAI.ToggleCertificatesRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deactivate certificates at the organization level.<br/>
        /// You can atomically and idempotently deactivate up to 10 certificates at a time.
        /// </summary>
        /// <param name="certificateIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListCertificatesResponse> DeactivateCertificatesForOrganizationAsync(
            global::System.Collections.Generic.IList<string> certificateIds,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}