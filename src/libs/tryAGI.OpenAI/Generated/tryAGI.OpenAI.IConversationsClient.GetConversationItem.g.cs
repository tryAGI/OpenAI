#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Retrieve an item<br/>
        /// Get a single item from a conversation with the given IDs.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="itemId">
        /// Example: msg_abc
        /// </param>
        /// <param name="include"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationItem> GetConversationItemAsync(
            string conversationId,
            string itemId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Includable>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}