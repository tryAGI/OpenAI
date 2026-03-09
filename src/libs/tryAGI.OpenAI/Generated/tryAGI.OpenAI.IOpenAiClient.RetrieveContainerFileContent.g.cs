#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve Container File Content<br/>
        /// Retrieves a container file content.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task RetrieveContainerFileContentAsync(
            string containerId,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}