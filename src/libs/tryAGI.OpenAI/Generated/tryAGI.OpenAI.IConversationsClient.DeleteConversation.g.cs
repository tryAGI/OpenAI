#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Delete a conversation<br/>
        /// Delete a conversation. Items in the conversation will not be deleted.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeletedConversationResource> DeleteConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}