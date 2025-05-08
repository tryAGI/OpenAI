#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Delete a certificate from the organization.<br/>
        /// The certificate must be inactive for the organization and all projects.
        /// </summary>
        /// <param name="certificateId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeleteCertificateResponse> DeleteCertificateAsync(
            string certificateId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}