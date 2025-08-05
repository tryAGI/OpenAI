#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Cancel a response<br/>
        /// Cancels a model response with the given ID. Only responses created with<br/>
        /// the `background` parameter set to `true` can be cancelled. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/background).
        /// </summary>
        /// <param name="responseId">
        /// Example: resp_677efb5139a88190b512bc3fef8e535d
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Response> CancelResponseAsync(
            string responseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}