#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Update a conversation<br/>
        /// Update a conversation's metadata with the given ID.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> UpdateConversationAsync(
            string conversationId,
            global::tryAGI.OpenAI.UpdateConversationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a conversation<br/>
        /// Update a conversation's metadata with the given ID.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be         useful for storing additional information about the object in a structured         format, and querying for objects via API or the dashboard.<br/>
        ///         Keys are strings with a maximum length of 64 characters. Values are strings         with a maximum length of 512 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> UpdateConversationAsync(
            string conversationId,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}