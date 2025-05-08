#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// Get a certificate that has been uploaded to the organization.<br/>
        /// You can get a certificate regardless of whether it is active or not.
        /// </summary>
        /// <param name="certId"></param>
        /// <param name="include"></param>
        /// <param name="certificateId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Certificate> GetCertificateAsync(
            string certId,
            string certificateId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GetCertificateIncludeItem>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}