#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Cancel a response<br/>
        /// Cancels a model response with the given ID. Only responses created with<br/>
        /// the `background` parameter set to `true` can be cancelled.<br/>
        /// [Learn more](https://developers.openai.com/api/docs/guides/background).
        /// </summary>
        /// <param name="responseId">
        /// Example: resp_677efb5139a88190b512bc3fef8e535d
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Response> CancelResponseAsync(
            string responseId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a response<br/>
        /// Cancels a model response with the given ID. Only responses created with<br/>
        /// the `background` parameter set to `true` can be cancelled.<br/>
        /// [Learn more](https://developers.openai.com/api/docs/guides/background).
        /// </summary>
        /// <param name="responseId">
        /// Example: resp_677efb5139a88190b512bc3fef8e535d
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.Response>> CancelResponseAsResponseAsync(
            string responseId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}