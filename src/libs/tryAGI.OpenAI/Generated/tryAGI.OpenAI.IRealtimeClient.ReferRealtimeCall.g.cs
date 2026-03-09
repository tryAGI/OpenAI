#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Transfer an active SIP call to a new destination using the SIP REFER verb.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task ReferRealtimeCallAsync(
            string callId,

            global::tryAGI.OpenAI.RealtimeCallReferRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Transfer an active SIP call to a new destination using the SIP REFER verb.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="targetUri">
        /// URI that should appear in the SIP Refer-To header. Supports values like<br/>
        /// `tel:+14155550123` or `sip:agent@example.com`.<br/>
        /// Example: tel:+14155550123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReferRealtimeCallAsync(
            string callId,
            string targetUri,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}