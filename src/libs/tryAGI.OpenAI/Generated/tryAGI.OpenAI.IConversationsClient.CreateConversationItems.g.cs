#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create items<br/>
        /// Create items in a conversation with the given ID.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="include"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationItemList> CreateConversationItemsAsync(
            string conversationId,
            global::tryAGI.OpenAI.CreateConversationItemsRequest request,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Includable>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create items<br/>
        /// Create items in a conversation with the given ID.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="include"></param>
        /// <param name="items">
        /// The items to add to the conversation. You may add up to 20 items at a time.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationItemList> CreateConversationItemsAsync(
            string conversationId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem> items,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Includable>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}