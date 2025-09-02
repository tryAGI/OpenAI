
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the server VAD timeout is triggered for the input audio buffer.
    /// </summary>
    public sealed partial class RealtimeServerEventInputAudioBufferTimeoutTriggered
    {
        /// <summary>
        /// Millisecond offset where speech ended within the buffered audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioEndMs { get; set; }

        /// <summary>
        /// Millisecond offset where speech started within the buffered audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioStartMs { get; set; }

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the item associated with this segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.timeout_triggered`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventInputAudioBufferTimeoutTriggeredTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferTimeoutTriggered" /> class.
        /// </summary>
        /// <param name="audioEndMs">
        /// Millisecond offset where speech ended within the buffered audio.
        /// </param>
        /// <param name="audioStartMs">
        /// Millisecond offset where speech started within the buffered audio.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item associated with this segment.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.timeout_triggered`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventInputAudioBufferTimeoutTriggered(
            int audioEndMs,
            int audioStartMs,
            string eventId,
            string itemId,
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggeredType type)
        {
            this.AudioEndMs = audioEndMs;
            this.AudioStartMs = audioStartMs;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferTimeoutTriggered" /> class.
        /// </summary>
        public RealtimeServerEventInputAudioBufferTimeoutTriggered()
        {
        }
    }
}