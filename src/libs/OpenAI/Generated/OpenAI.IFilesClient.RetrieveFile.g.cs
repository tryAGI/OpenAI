#nullable enable

namespace OpenAI
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns information about a specific file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.OpenAIFile> RetrieveFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}