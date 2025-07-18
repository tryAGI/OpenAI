#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Deactivate certificates at the project level. You can atomically and <br/>
        /// idempotently deactivate up to 10 certificates at a time.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListCertificatesResponse> DeactivateProjectCertificatesAsync(
            string projectId,
            global::tryAGI.OpenAI.ToggleCertificatesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deactivate certificates at the project level. You can atomically and <br/>
        /// idempotently deactivate up to 10 certificates at a time.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="certificateIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListCertificatesResponse> DeactivateProjectCertificatesAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> certificateIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}