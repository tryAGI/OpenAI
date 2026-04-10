#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// End an active Realtime API call, whether it was initiated over SIP or<br/>
        /// WebRTC.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task HangUpCallAsync(
            string callId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}