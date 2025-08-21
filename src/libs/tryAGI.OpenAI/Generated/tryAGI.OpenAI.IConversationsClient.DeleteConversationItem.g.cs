#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Delete an item<br/>
        /// Delete an item from a conversation with the given IDs.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="itemId">
        /// Example: msg_abc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> DeleteConversationItemAsync(
            string conversationId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}