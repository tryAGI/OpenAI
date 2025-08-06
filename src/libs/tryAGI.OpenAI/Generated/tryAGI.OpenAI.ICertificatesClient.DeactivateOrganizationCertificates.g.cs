#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Deactivate certificates for organization<br/>
        /// Deactivate certificates at the organization level.<br/>
        /// You can atomically and idempotently deactivate up to 10 certificates at a time.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListCertificatesResponse> DeactivateOrganizationCertificatesAsync(
            global::tryAGI.OpenAI.ToggleCertificatesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deactivate certificates for organization<br/>
        /// Deactivate certificates at the organization level.<br/>
        /// You can atomically and idempotently deactivate up to 10 certificates at a time.
        /// </summary>
        /// <param name="certificateIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListCertificatesResponse> DeactivateOrganizationCertificatesAsync(
            global::System.Collections.Generic.IList<string> certificateIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}