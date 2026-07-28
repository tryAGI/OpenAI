
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event data payload.
    /// </summary>
    public sealed partial class WebhookLiveCallIncomingData
    {
        /// <summary>
        /// The Transceiver `rtc_...` ID of the pending SIP session. The same<br/>
        /// value appears as `call_id` in `realtime.call.incoming`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Headers from the SIP Invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader> SipHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveCallIncomingData" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The Transceiver `rtc_...` ID of the pending SIP session. The same<br/>
        /// value appears as `call_id` in `realtime.call.incoming`.
        /// </param>
        /// <param name="sipHeaders">
        /// Headers from the SIP Invite.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookLiveCallIncomingData(
            string sessionId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader> sipHeaders)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.SipHeaders = sipHeaders ?? throw new global::System.ArgumentNullException(nameof(sipHeaders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveCallIncomingData" /> class.
        /// </summary>
        public WebhookLiveCallIncomingData()
        {
        }

    }
}