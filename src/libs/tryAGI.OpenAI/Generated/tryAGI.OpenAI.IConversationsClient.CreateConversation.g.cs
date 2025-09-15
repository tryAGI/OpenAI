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
            global::tryAGI.OpenAI.CreateConversationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a conversation<br/>
        /// Create a conversation.
        /// </summary>
        /// <param name="items">
        /// Initial items to include in the conversation context.<br/>
        /// You may add up to 20 items at a time.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard.<br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationResource> CreateConversationAsync(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? items = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}