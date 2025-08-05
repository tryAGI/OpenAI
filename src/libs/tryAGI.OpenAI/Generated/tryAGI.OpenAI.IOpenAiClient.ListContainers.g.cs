#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List containers<br/>
        /// List Containers
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ContainerListResource> ListContainersAsync(
            int? limit = default,
            global::tryAGI.OpenAI.ListContainersOrder? order = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}