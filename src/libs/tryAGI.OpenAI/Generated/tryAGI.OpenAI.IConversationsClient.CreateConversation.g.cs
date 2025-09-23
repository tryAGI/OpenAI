#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create a conversation<br/>
        /// Create a conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> CreateConversationAsync(
            global::tryAGI.OpenAI.CreateConversationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a conversation<br/>
        /// Create a conversation.
        /// </summary>
        /// <param name="items">
        /// Initial items to include in the conversation context. You may add up to 20 items at a time.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> CreateConversationAsync(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? items = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}