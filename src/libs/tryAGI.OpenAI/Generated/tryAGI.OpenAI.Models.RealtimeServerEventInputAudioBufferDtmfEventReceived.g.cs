
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// **SIP Only:** Returned when an DTMF event is received. A DTMF event is a message that<br/>
    /// represents a telephone keypad press (0–9, *, #, A–D). The `event` property<br/>
    /// is the keypad that the user press. The `received_at` is the UTC Unix Timestamp<br/>
    /// that the server received the event.
    /// </summary>
    public sealed partial class RealtimeServerEventInputAudioBufferDtmfEventReceived
    {
        /// <summary>
        /// The event type, must be `input_audio_buffer.dtmf_event_received`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferDtmfEventReceivedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType Type { get; set; }

        /// <summary>
        /// The telephone keypad that was pressed by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// UTC Unix Timestamp when DTMF Event was received by server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ReceivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferDtmfEventReceived" /> class.
        /// </summary>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.dtmf_event_received`.
        /// </param>
        /// <param name="event">
        /// The telephone keypad that was pressed by the user.
        /// </param>
        /// <param name="receivedAt">
        /// UTC Unix Timestamp when DTMF Event was received by server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventInputAudioBufferDtmfEventReceived(
            string @event,
            global::System.DateTimeOffset receivedAt,
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceivedType type)
        {
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.ReceivedAt = receivedAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferDtmfEventReceived" /> class.
        /// </summary>
        public RealtimeServerEventInputAudioBufferDtmfEventReceived()
        {
        }
    }
}