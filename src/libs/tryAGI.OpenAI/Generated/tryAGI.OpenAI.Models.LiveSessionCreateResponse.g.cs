
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The created Live session and its transport. WebRTC creation returns 201 Created with an SDP answer. Outbound SIP creation returns 201 Created after initialization, before the callee necessarily answers, without SDP or trunk credentials.
    /// </summary>
    public sealed partial class LiveSessionCreateResponse
    {
        /// <summary>
        /// The newly created Live session. Use its ID for session controls and sideband connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Session5 Session { get; set; }

        /// <summary>
        /// WebRTC transport with an SDP answer, or SIP transport without SDP or trunk credentials. For SIP, attach a sideband using session.id to receive transport.ringing, transport.answered, and transport.failed notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Transport2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Transport2 Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCreateResponse" /> class.
        /// </summary>
        /// <param name="session">
        /// The newly created Live session. Use its ID for session controls and sideband connections.
        /// </param>
        /// <param name="transport">
        /// WebRTC transport with an SDP answer, or SIP transport without SDP or trunk credentials. For SIP, attach a sideband using session.id to receive transport.ringing, transport.answered, and transport.failed notifications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionCreateResponse(
            global::tryAGI.OpenAI.Session5 session,
            global::tryAGI.OpenAI.Transport2 transport)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionCreateResponse" /> class.
        /// </summary>
        public LiveSessionCreateResponse()
        {
        }

    }
}