#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Delete a container<br/>
        /// Delete Container
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteContainerAsync(
            string containerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}