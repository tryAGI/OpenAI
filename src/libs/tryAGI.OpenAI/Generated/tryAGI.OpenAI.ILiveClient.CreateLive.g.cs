#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ILiveClient
    {
        /// <summary>
        /// Create session<br/>
        /// Create a Live WebRTC session or place an outbound SIP call. Start with the<br/>
        /// [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) for session configuration<br/>
        /// and [Telephony and SIP](https://developers.openai.com/api/docs/guides/voice-sip?api=live#place-an-outbound-call)<br/>
        /// for trunk setup and call monitoring.<br/>
        /// Set transport.type to `webrtc` and supply an SDP offer, or set it to `sip`<br/>
        /// and supply an E.164 destination and trunk credentials. Outbound SIP calling<br/>
        /// must be enabled for your organization.<br/>
        /// Ringing is limited to 3 minutes and connected calls to 2 hours; these limits<br/>
        /// are not configurable in the request.<br/>
        /// Returns `201 Created` after session initialization. WebRTC responses include an<br/>
        /// SDP answer. SIP responses do not wait for the callee to answer. Attach a<br/>
        /// sideband connection using session.id to monitor SIP call progress.<br/>
        /// Each SIP request creates a new call. If a request times out or the connection<br/>
        /// fails, retry with caution: the original request may have succeeded, and a<br/>
        /// retry can place another call.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.LiveSessionCreateResponse> CreateLiveAsync(

            global::tryAGI.OpenAI.LiveSessionCreateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session<br/>
        /// Create a Live WebRTC session or place an outbound SIP call. Start with the<br/>
        /// [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) for session configuration<br/>
        /// and [Telephony and SIP](https://developers.openai.com/api/docs/guides/voice-sip?api=live#place-an-outbound-call)<br/>
        /// for trunk setup and call monitoring.<br/>
        /// Set transport.type to `webrtc` and supply an SDP offer, or set it to `sip`<br/>
        /// and supply an E.164 destination and trunk credentials. Outbound SIP calling<br/>
        /// must be enabled for your organization.<br/>
        /// Ringing is limited to 3 minutes and connected calls to 2 hours; these limits<br/>
        /// are not configurable in the request.<br/>
        /// Returns `201 Created` after session initialization. WebRTC responses include an<br/>
        /// SDP answer. SIP responses do not wait for the callee to answer. Attach a<br/>
        /// sideband connection using session.id to monitor SIP call progress.<br/>
        /// Each SIP request creates a new call. If a request times out or the connection<br/>
        /// fails, retry with caution: the original request may have succeeded, and a<br/>
        /// retry can place another call.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.LiveSessionCreateResponse>> CreateLiveAsResponseAsync(

            global::tryAGI.OpenAI.LiveSessionCreateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session<br/>
        /// Create a Live WebRTC session or place an outbound SIP call. Start with the<br/>
        /// [Live prompting guide](https://developers.openai.com/api/docs/guides/live-prompting) for session configuration<br/>
        /// and [Telephony and SIP](https://developers.openai.com/api/docs/guides/voice-sip?api=live#place-an-outbound-call)<br/>
        /// for trunk setup and call monitoring.<br/>
        /// Set transport.type to `webrtc` and supply an SDP offer, or set it to `sip`<br/>
        /// and supply an E.164 destination and trunk credentials. Outbound SIP calling<br/>
        /// must be enabled for your organization.<br/>
        /// Ringing is limited to 3 minutes and connected calls to 2 hours; these limits<br/>
        /// are not configurable in the request.<br/>
        /// Returns `201 Created` after session initialization. WebRTC responses include an<br/>
        /// SDP answer. SIP responses do not wait for the callee to answer. Attach a<br/>
        /// sideband connection using session.id to monitor SIP call progress.<br/>
        /// Each SIP request creates a new call. If a request times out or the connection<br/>
        /// fails, retry with caution: the original request may have succeeded, and a<br/>
        /// retry can place another call.
        /// </summary>
        /// <param name="session">
        /// Startup configuration for the Live session.
        /// </param>
        /// <param name="transport">
        /// WebRTC transport with an SDP offer, or SIP transport with a destination and per-call trunk credentials.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.LiveSessionCreateResponse> CreateLiveAsync(
            global::tryAGI.OpenAI.LiveMediaSessionCreateParams session,
            global::tryAGI.OpenAI.Transport transport,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}