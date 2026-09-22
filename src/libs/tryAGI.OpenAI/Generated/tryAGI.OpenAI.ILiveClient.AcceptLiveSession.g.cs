#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ILiveClient
    {
        /// <summary>
        /// Accept call<br/>
        /// Accept an incoming SIP call. Supply session with type live, the model, and startup configuration. Before accepting calls, follow the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) to write frontend conversation instructions and a separate backend prompt. SIP media format is negotiated; omit audio.format.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AcceptLiveSessionAsync(
            string sessionId,

            global::tryAGI.OpenAI.LiveCallAcceptRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Accept call<br/>
        /// Accept an incoming SIP call. Supply session with type live, the model, and startup configuration. Before accepting calls, follow the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) to write frontend conversation instructions and a separate backend prompt. SIP media format is negotiated; omit audio.format.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse> AcceptLiveSessionAsResponseAsync(
            string sessionId,

            global::tryAGI.OpenAI.LiveCallAcceptRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Accept call<br/>
        /// Accept an incoming SIP call. Supply session with type live, the model, and startup configuration. Before accepting calls, follow the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) to write frontend conversation instructions and a separate backend prompt. SIP media format is negotiated; omit audio.format.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="session">
        /// Model and startup configuration for the Live session that answers the incoming SIP call.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AcceptLiveSessionAsync(
            string sessionId,
            global::tryAGI.OpenAI.LiveCallAcceptSession session,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}