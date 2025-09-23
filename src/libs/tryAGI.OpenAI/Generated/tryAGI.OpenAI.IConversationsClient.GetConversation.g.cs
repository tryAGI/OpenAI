#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Retrieve a conversation<br/>
        /// Get a conversation
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> GetConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}