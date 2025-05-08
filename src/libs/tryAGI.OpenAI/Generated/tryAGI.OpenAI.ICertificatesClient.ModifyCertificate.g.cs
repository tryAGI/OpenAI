#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Modify a certificate. Note that only the name can be modified.
        /// </summary>
        /// <param name="certificateId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Certificate> ModifyCertificateAsync(
            string certificateId,
            global::tryAGI.OpenAI.ModifyCertificateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modify a certificate. Note that only the name can be modified.
        /// </summary>
        /// <param name="certificateId"></param>
        /// <param name="name">
        /// The updated name for the certificate
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Certificate> ModifyCertificateAsync(
            string certificateId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}