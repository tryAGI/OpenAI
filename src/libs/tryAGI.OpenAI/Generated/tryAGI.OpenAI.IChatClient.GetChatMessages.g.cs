#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Get the messages in a stored chat completion. Only Chat Completions that<br/>
        /// have been created with the `store` parameter set to `true` will be<br/>
        /// returned.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ChatCompletionMessageList> GetChatMessagesAsync(
            string completionId,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.GetChatCompletionMessagesOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the messages in a stored chat completion. Only Chat Completions that<br/>
        /// have been created with the `store` parameter set to `true` will be<br/>
        /// returned.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ChatCompletionMessageList>> GetChatMessagesAsResponseAsync(
            string completionId,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.GetChatCompletionMessagesOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}