#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Cancels the Upload. No Parts may be added after an Upload is cancelled.
        /// </summary>
        /// <param name="uploadId">
        /// Example: upload_abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Upload> CancelUploadAsync(
            string uploadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}