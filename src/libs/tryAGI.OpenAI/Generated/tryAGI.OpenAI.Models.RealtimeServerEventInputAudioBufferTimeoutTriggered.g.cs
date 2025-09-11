
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the Server VAD timeout is triggered for the input audio buffer. This is configured<br/>
    /// with `idle_timeout_ms` in the `turn_detection` settings of the session, and it indicates that<br/>
    /// there hasn't been any speech detected for the configured duration.<br/>
    /// The `audio_start_ms` and `audio_end_ms` fields indicate the segment of audio after the last<br/>
    /// model response up to the triggering time, as an offset from the beginning of audio written<br/>
    /// to the input audio buffer. This means it demarcates the segment of audio that was silent and<br/>
    /// the difference between the start and end values will roughly match the configured timeout.<br/>
    /// The empty audio will be committed to the conversation as an `input_audio` item (there will be a<br/>
    /// `input_audio_buffer.committed` event) and a model response will be generated. There may be speech<br/>
    /// that didn't trigger VAD but is still detected by the model, so the model may respond with<br/>
    /// something relevant to the conversation or a prompt to continue speaking.
    /// </summary>
    public sealed partial class RealtimeServerEventInputAudioBufferTimeoutTriggered
    {
        /// <summary>
        /// Millisecond offset of audio written to the input audio buffer at the time the timeout was triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioEndMs { get; set; }

        /// <summary>
        /// Millisecond offset of audio written to the input audio buffer that was after the playback time of the last model response.
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
        /// Millisecond offset of audio written to the input audio buffer at the time the timeout was triggered.
        /// </param>
        /// <param name="audioStartMs">
        /// Millisecond offset of audio written to the input audio buffer that was after the playback time of the last model response.
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