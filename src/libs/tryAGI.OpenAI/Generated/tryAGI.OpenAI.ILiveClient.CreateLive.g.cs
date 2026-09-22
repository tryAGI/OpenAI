#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ILiveClient
    {
        /// <summary>
        /// Create session<br/>
        /// Create a Live WebRTC session. Start with the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.LiveCreateResponse> CreateLiveAsync(

            global::tryAGI.OpenAI.LiveCreateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session<br/>
        /// Create a Live WebRTC session. Start with the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.LiveCreateResponse>> CreateLiveAsResponseAsync(

            global::tryAGI.OpenAI.LiveCreateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session<br/>
        /// Create a Live WebRTC session. Start with the [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting).
        /// </summary>
        /// <param name="session">
        /// Startup configuration for the Live session.
        /// </param>
        /// <param name="transport">
        /// WebRTC transport with the browser's SDP offer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.LiveCreateResponse> CreateLiveAsync(
            global::tryAGI.OpenAI.LiveMediaSessionCreateParams session,
            global::tryAGI.OpenAI.LiveWebRTCTransport transport,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}