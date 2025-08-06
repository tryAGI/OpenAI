#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Upload certificate<br/>
        /// Upload a certificate to the organization. This does **not** automatically activate the certificate.<br/>
        /// Organizations can upload up to 50 certificates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Certificate> UploadCertificateAsync(
            global::tryAGI.OpenAI.UploadCertificateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload certificate<br/>
        /// Upload a certificate to the organization. This does **not** automatically activate the certificate.<br/>
        /// Organizations can upload up to 50 certificates.
        /// </summary>
        /// <param name="content">
        /// The certificate content in PEM format
        /// </param>
        /// <param name="name">
        /// An optional name for the certificate
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Certificate> UploadCertificateAsync(
            string content,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}