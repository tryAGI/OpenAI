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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ContainerResource> CreateContainerAsync(

            global::tryAGI.OpenAI.CreateContainerBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Container<br/>
        /// Creates a container.
        /// </summary>
        /// <param name="name">
        /// Name of the container to create.
        /// </param>
        /// <param name="fileIds">
        /// IDs of files to copy to the container.
        /// </param>
        /// <param name="expiresAfter">
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </param>
        /// <param name="skills">
        /// An optional list of skills referenced by id or inline data.
        /// </param>
        /// <param name="memoryLimit">
        /// Optional memory limit for the container. Defaults to "1g".
        /// </param>
        /// <param name="networkPolicy">
        /// Network access policy for the container.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ContainerResource> CreateContainerAsync(
            string name,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? expiresAfter = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>? skills = default,
            global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit? memoryLimit = default,
            global::tryAGI.OpenAI.NetworkPolicy? networkPolicy = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}