#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ILiveClient
    {
        /// <summary>
        /// Fork session<br/>
        /// Fork a stored Live session onto a new WebRTC connection.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.LiveCreateResponse> ForkLiveSessionAsync(
            string sessionId,

            global::tryAGI.OpenAI.LiveForkRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork session<br/>
        /// Fork a stored Live session onto a new WebRTC connection.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.LiveCreateResponse>> ForkLiveSessionAsResponseAsync(
            string sessionId,

            global::tryAGI.OpenAI.LiveForkRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork session<br/>
        /// Fork a stored Live session onto a new WebRTC connection.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="session">
        /// Optional configuration overrides for the new Live session. Omit this object or send an empty object to inherit the stored session's settings.
        /// </param>
        /// <param name="transport">
        /// WebRTC transport with an SDP offer for the new connection to the forked session.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.LiveCreateResponse> ForkLiveSessionAsync(
            string sessionId,
            global::tryAGI.OpenAI.LiveWebRTCTransport transport,
            global::tryAGI.OpenAI.LiveMediaSessionForkParams? session = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}