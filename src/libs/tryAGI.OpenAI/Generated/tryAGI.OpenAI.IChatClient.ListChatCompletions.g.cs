#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IChatClient
    {
        /// <summary>
        /// List stored Chat Completions. Only Chat Completions that have been stored<br/>
        /// with the `store` parameter set to `true` will be returned.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="metadata"></param>
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
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ChatCompletionList> ListChatCompletionsAsync(
            string? model = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListChatCompletionsOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}