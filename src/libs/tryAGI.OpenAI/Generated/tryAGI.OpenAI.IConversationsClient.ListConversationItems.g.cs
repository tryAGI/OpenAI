#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// List items<br/>
        /// List all items for a conversation with the given ID.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="include"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationItemList> ListConversationItemsAsync(
            string conversationId,
            int? limit = default,
            global::tryAGI.OpenAI.ListConversationItemsOrder? order = default,
            string? after = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Includable>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}