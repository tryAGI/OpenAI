#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create Container<br/>
        /// Creates a container.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ContainerResource> CreateContainerAsync(
            global::tryAGI.OpenAI.CreateContainerBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Container<br/>
        /// Creates a container.
        /// </summary>
        /// <param name="expiresAfter">
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </param>
        /// <param name="fileIds">
        /// IDs of files to copy to the container.
        /// </param>
        /// <param name="name">
        /// Name of the container to create.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ContainerResource> CreateContainerAsync(
            string name,
            global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? expiresAfter = default,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}