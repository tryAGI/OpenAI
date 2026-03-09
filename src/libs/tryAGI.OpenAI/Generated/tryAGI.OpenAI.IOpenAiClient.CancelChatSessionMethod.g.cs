#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Cancel an active ChatKit session and return its most recent metadata.<br/>
        /// Cancelling prevents new requests from using the issued client secret.
        /// </summary>
        /// <param name="sessionId">
        /// Example: cksess_123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ChatSessionResource> CancelChatSessionMethodAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}