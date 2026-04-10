#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List items that belong to a ChatKit thread.
        /// </summary>
        /// <param name="threadId">
        /// Example: cthr_123
        /// </param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after">
        /// List items created after this thread item ID. Defaults to null for the first page.
        /// </param>
        /// <param name="before">
        /// List items created before this thread item ID. Defaults to null for the newest results.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ThreadItemListResource> ListChatKitThreadItemsAsync(
            string threadId,
            int? limit = default,
            global::tryAGI.OpenAI.OrderEnum? order = default,
            string? after = default,
            string? before = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}