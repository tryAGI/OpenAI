
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Returned when speech stops in server VAD mode.
    /// </summary>
    public sealed partial class InputAudioBufferSpeechStoppedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputAudioBufferSpeechStoppedPayloadTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayloadType Type { get; set; }

        /// <summary>
        /// Milliseconds since the session started when speech stopped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        public int? AudioEndMs { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferSpeechStoppedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="audioEndMs">
        /// Milliseconds since the session started when speech stopped.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudioBufferSpeechStoppedPayload(
            string eventId,
            global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayloadType type,
            int? audioEndMs,
            string? itemId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.AudioEndMs = audioEndMs;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferSpeechStoppedPayload" /> class.
        /// </summary>
        public InputAudioBufferSpeechStoppedPayload()
        {
        }
    }
}