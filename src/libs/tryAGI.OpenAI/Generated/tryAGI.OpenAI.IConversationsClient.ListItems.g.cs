#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IConversationsClient
    {
        /// <summary>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ConversationItemList> ListItemsAsync(
            string conversationId,
            int? limit = default,
            global::tryAGI.OpenAI.ListConversationItemsOrder? order = default,
            string? after = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? include = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ConversationItemList>> ListItemsAsResponseAsync(
            string conversationId,
            int? limit = default,
            global::tryAGI.OpenAI.ListConversationItemsOrder? order = default,
            string? after = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? include = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListItemsAsync as an IAsyncEnumerable<global::tryAGI.OpenAI.ConversationItem> that auto-pages over the response.
        /// </summary>
        /// <param name="conversationId">
        /// Example: conv_123
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order"></param>
        /// <param name="include"></param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.ConversationItem> ListItemsAutoPagingAsync(
            string conversationId,             int? limit = default,
            global::tryAGI.OpenAI.ListConversationItemsOrder? order = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? include = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}