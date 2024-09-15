#nullable enable

namespace OpenAI
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns the contents of the specified file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}