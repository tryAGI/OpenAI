#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns the contents of the specified file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}