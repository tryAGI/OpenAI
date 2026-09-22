
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event data payload.
    /// </summary>
    public sealed partial class WebhookRealtimeCallIncomingData
    {
        /// <summary>
        /// The ID of the pending SIP call. Pass this value unchanged when<br/>
        /// accepting or rejecting the call through the Realtime API. For the<br/>
        /// Live API, use the `session_id` from `live.transport.incoming` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Media protection selected on the SIP leg during SDP negotiation. `srtp`<br/>
        /// indicates SRTP; `rtp` indicates unencrypted RTP. Omitted when unknown.<br/>
        /// This does not describe SIP signaling security or confirm that media has<br/>
        /// flowed. Clients should handle unrecognized values as unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_media_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity?, string>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity?, string>? SipMediaSecurity { get; set; }

        /// <summary>
        /// Headers from the SIP INVITE, excluding SIP authorization headers.<br/>
        /// Retained names, values, repeated entries, and order are preserved.<br/>
        /// Treat these values as untrusted call metadata.
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
        /// The ID of the pending SIP call. Pass this value unchanged when<br/>
        /// accepting or rejecting the call through the Realtime API. For the<br/>
        /// Live API, use the `session_id` from `live.transport.incoming` instead.
        /// </param>
        /// <param name="sipHeaders">
        /// Headers from the SIP INVITE, excluding SIP authorization headers.<br/>
        /// Retained names, values, repeated entries, and order are preserved.<br/>
        /// Treat these values as untrusted call metadata.
        /// </param>
        /// <param name="sipMediaSecurity">
        /// Media protection selected on the SIP leg during SDP negotiation. `srtp`<br/>
        /// indicates SRTP; `rtp` indicates unencrypted RTP. Omitted when unknown.<br/>
        /// This does not describe SIP signaling security or confirm that media has<br/>
        /// flowed. Clients should handle unrecognized values as unknown.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRealtimeCallIncomingData(
            string callId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipHeader> sipHeaders,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookRealtimeCallIncomingDataSipMediaSecurity?, string>? sipMediaSecurity)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.SipMediaSecurity = sipMediaSecurity;
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