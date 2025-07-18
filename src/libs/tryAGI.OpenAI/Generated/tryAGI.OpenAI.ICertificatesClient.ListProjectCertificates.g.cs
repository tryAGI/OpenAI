#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// List certificates for this project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListCertificatesResponse> ListProjectCertificatesAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.ListProjectCertificatesOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}