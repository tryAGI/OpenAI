#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ILiveClient
    {
        /// <summary>
        /// Transfer call<br/>
        /// Transfer a SIP call to another destination. Supply a nonblank target_uri for the SIP Refer-To header.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task ReferLiveSessionAsync(
            string sessionId,

            global::tryAGI.OpenAI.LiveCallReferRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer call<br/>
        /// Transfer a SIP call to another destination. Supply a nonblank target_uri for the SIP Refer-To header.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse> ReferLiveSessionAsResponseAsync(
            string sessionId,

            global::tryAGI.OpenAI.LiveCallReferRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer call<br/>
        /// Transfer a SIP call to another destination. Supply a nonblank target_uri for the SIP Refer-To header.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="targetUri">
        /// Nonblank URI for the SIP Refer-To header, such as tel:+14155550123 or sip:agent@example.com.<br/>
        /// Example: tel:+14155550123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReferLiveSessionAsync(
            string sessionId,
            string targetUri,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}