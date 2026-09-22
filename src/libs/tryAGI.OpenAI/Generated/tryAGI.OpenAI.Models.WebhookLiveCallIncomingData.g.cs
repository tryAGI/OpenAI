
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Event data payload.
    /// </summary>
    public sealed partial class WebhookLiveCallIncomingData
    {
        /// <summary>
        /// The `live_...` ID of the pending SIP session. Pass this value unchanged<br/>
        /// to Live call controls and sideband connections. The corresponding<br/>
        /// `realtime.call.incoming` event uses a separate `rtc_...` call ID.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity?, string>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity?, string>? SipMediaSecurity { get; set; }

        /// <summary>
        /// Headers from the SIP INVITE, excluding SIP authorization headers.<br/>
        /// Retained names, values, repeated entries, and order are preserved.<br/>
        /// Treat these values as untrusted call metadata.
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
        /// The `live_...` ID of the pending SIP session. Pass this value unchanged<br/>
        /// to Live call controls and sideband connections. The corresponding<br/>
        /// `realtime.call.incoming` event uses a separate `rtc_...` call ID.
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
        public WebhookLiveCallIncomingData(
            string sessionId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipHeader> sipHeaders,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.WebhookLiveCallIncomingDataSipMediaSecurity?, string>? sipMediaSecurity)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.SipMediaSecurity = sipMediaSecurity;
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