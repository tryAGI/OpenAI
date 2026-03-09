#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve a ChatKit thread by its identifier.
        /// </summary>
        /// <param name="threadId">
        /// Example: cthr_123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ThreadResource> GetThreadMethodAsync(
            string threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}