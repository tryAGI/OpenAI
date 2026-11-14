
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the input audio buffer is cleared by the client with a <br/>
    /// `input_audio_buffer.clear` event.
    /// </summary>
    public sealed partial class RealtimeServerEventInputAudioBufferCleared
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.cleared`.
        /// </summary>
        /// <default>"input_audio_buffer.cleared"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_audio_buffer.cleared";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferCleared" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.cleared`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventInputAudioBufferCleared(
            string eventId,
            string type = "input_audio_buffer.cleared")
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferCleared" /> class.
        /// </summary>
        public RealtimeServerEventInputAudioBufferCleared()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RealtimeServerEventInputAudioBufferCleared"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RealtimeServerEventInputAudioBufferCleared FromEventId(string eventId)
        {
            return new RealtimeServerEventInputAudioBufferCleared
            {
                EventId = eventId,
            };
        }

    }
}