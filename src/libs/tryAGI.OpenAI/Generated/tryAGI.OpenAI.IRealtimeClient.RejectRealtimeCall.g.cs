#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Decline an incoming SIP call by returning a SIP status code to the caller.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task RejectRealtimeCallAsync(
            string callId,

            global::tryAGI.OpenAI.RealtimeCallRejectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Decline an incoming SIP call by returning a SIP status code to the caller.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="statusCode">
        /// SIP response code to send back to the caller. Defaults to `603` (Decline)<br/>
        /// when omitted.<br/>
        /// Example: 486
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RejectRealtimeCallAsync(
            string callId,
            int? statusCode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}