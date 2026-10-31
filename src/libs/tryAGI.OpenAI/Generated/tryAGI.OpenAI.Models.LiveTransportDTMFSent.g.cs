
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A SIP DTMF keypress successfully sent to the SIP trunk. Delivered only to sideband observers; this is not a client command.<br/>
    /// Example: {"type":"transport.dtmf.sent","event_id":"event_dtmf_2","event":"#"}
    /// </summary>
    public sealed partial class LiveTransportDTMFSent
    {
        /// <summary>
        /// Default Value: transport.dtmf.sent
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveTransportDTMFSentType.TransportDtmfSent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveTransportDTMFSentTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveTransportDTMFSentType Type { get; set; } = global::tryAGI.OpenAI.LiveTransportDTMFSentType.TransportDtmfSent;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// The event_id of the client command, when supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportDTMFSent" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="event"></param>
        /// <param name="clientEventId">
        /// The event_id of the client command, when supplied.
        /// </param>
        /// <param name="type">
        /// Default Value: transport.dtmf.sent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveTransportDTMFSent(
            string eventId,
            string @event,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveTransportDTMFSentType type = global::tryAGI.OpenAI.LiveTransportDTMFSentType.TransportDtmfSent)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.ClientEventId = clientEventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportDTMFSent" /> class.
        /// </summary>
        public LiveTransportDTMFSent()
        {
        }

    }
}