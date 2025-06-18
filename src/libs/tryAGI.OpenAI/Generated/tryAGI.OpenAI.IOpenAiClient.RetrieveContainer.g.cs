#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve Container<br/>
        /// Retrieves a container.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ContainerResource> RetrieveContainerAsync(
            string containerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}