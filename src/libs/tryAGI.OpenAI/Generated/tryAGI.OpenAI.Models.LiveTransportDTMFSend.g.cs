
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A SIP DTMF keypress successfully sent by the hosted tool. Delivered only to sideband observers; this is not a client command.<br/>
    /// Example: {"type":"transport.dtmf.send","event_id":"event_dtmf_2","event":"#"}
    /// </summary>
    public sealed partial class LiveTransportDTMFSend
    {
        /// <summary>
        /// Default Value: transport.dtmf.send
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveTransportDTMFSendType.TransportDtmfSend</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveTransportDTMFSendTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveTransportDTMFSendType Type { get; set; } = global::tryAGI.OpenAI.LiveTransportDTMFSendType.TransportDtmfSend;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportDTMFSend" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="event"></param>
        /// <param name="type">
        /// Default Value: transport.dtmf.send
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveTransportDTMFSend(
            string eventId,
            string @event,
            global::tryAGI.OpenAI.LiveTransportDTMFSendType type = global::tryAGI.OpenAI.LiveTransportDTMFSendType.TransportDtmfSend)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportDTMFSend" /> class.
        /// </summary>
        public LiveTransportDTMFSend()
        {
        }

    }
}