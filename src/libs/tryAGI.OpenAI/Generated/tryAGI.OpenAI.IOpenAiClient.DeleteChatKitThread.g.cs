#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Delete a ChatKit thread along with its items and stored attachments.
        /// </summary>
        /// <param name="threadId">
        /// Example: cthr_123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeletedThreadResource> DeleteChatKitThreadAsync(
            string threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}