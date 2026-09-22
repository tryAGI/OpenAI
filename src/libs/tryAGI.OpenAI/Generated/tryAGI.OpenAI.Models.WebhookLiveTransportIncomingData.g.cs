
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event data payload.
    /// </summary>
    public sealed partial class WebhookLiveTransportIncomingData
    {
        /// <summary>
        /// The incoming transport type. Always `sip`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebhookLiveTransportIncomingDataTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataType Type { get; set; }

        /// <summary>
        /// The `live_...` ID of the pending SIP session. Forward this value<br/>
        /// unchanged when accepting or rejecting the call through the Live API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Media protection selected on the SIP leg during SDP negotiation. `srtp`<br/>
        /// indicates SRTP; `rtp` indicates unencrypted RTP. Omitted when unknown.<br/>
        /// This does not describe SIP signaling security or confirm that media has<br/>
        /// flowed. Clients should handle unrecognized values as unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_media_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity?, string>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity?, string>? SipMediaSecurity { get; set; }

        /// <summary>
        /// Headers from the SIP INVITE, excluding SIP authorization headers.<br/>
        /// Retained names, values, repeated entries, and order are preserved.<br/>
        /// Treat these values as untrusted call metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader> SipHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveTransportIncomingData" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The `live_...` ID of the pending SIP session. Forward this value<br/>
        /// unchanged when accepting or rejecting the call through the Live API.
        /// </param>
        /// <param name="sipHeaders">
        /// Headers from the SIP INVITE, excluding SIP authorization headers.<br/>
        /// Retained names, values, repeated entries, and order are preserved.<br/>
        /// Treat these values as untrusted call metadata.
        /// </param>
        /// <param name="type">
        /// The incoming transport type. Always `sip`.
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
        public WebhookLiveTransportIncomingData(
            string sessionId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipHeader> sipHeaders,
            global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataType type,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveTransportIncomingDataSipMediaSecurity?, string>? sipMediaSecurity)
        {
            this.Type = type;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.SipMediaSecurity = sipMediaSecurity;
            this.SipHeaders = sipHeaders ?? throw new global::System.ArgumentNullException(nameof(sipHeaders));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveTransportIncomingData" /> class.
        /// </summary>
        public WebhookLiveTransportIncomingData()
        {
        }

    }
}