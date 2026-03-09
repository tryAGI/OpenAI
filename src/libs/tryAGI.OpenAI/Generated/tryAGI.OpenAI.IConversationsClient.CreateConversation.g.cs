#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create a conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> CreateConversationAsync(

            global::tryAGI.OpenAI.CreateConversationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a conversation.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="items"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> CreateConversationAsync(
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? items = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}