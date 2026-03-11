
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event data payload.
    /// </summary>
    public sealed partial class WebhookRealtimeCallIncomingData
    {
        /// <summary>
        /// The unique ID of this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Headers from the SIP Invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader> SipHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRealtimeCallIncomingData" /> class.
        /// </summary>
        /// <param name="callId">
        /// The unique ID of this call.
        /// </param>
        /// <param name="sipHeaders">
        /// Headers from the SIP Invite.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRealtimeCallIncomingData(
            string callId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader> sipHeaders)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.SipHeaders = sipHeaders ?? throw new global::System.ArgumentNullException(nameof(sipHeaders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRealtimeCallIncomingData" /> class.
        /// </summary>
        public WebhookRealtimeCallIncomingData()
        {
        }
    }
}