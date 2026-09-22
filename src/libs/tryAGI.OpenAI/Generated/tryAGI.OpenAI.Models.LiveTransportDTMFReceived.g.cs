
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A SIP DTMF keypress received from the caller. Delivered only to sideband observers.<br/>
    /// Example: {"type":"transport.dtmf.received","event_id":"event_dtmf_1","event":"5"}
    /// </summary>
    public sealed partial class LiveTransportDTMFReceived
    {
        /// <summary>
        /// Default Value: transport.dtmf.received
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveTransportDTMFReceivedType.TransportDtmfReceived</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveTransportDTMFReceivedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveTransportDTMFReceivedType Type { get; set; } = global::tryAGI.OpenAI.LiveTransportDTMFReceivedType.TransportDtmfReceived;

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
        /// Initializes a new instance of the <see cref="LiveTransportDTMFReceived" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="event"></param>
        /// <param name="type">
        /// Default Value: transport.dtmf.received
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveTransportDTMFReceived(
            string eventId,
            string @event,
            global::tryAGI.OpenAI.LiveTransportDTMFReceivedType type = global::tryAGI.OpenAI.LiveTransportDTMFReceivedType.TransportDtmfReceived)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTransportDTMFReceived" /> class.
        /// </summary>
        public LiveTransportDTMFReceived()
        {
        }

    }
}