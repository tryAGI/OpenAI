
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Returned in server turn detection mode when speech is detected.
    /// </summary>
    public sealed partial class RealtimeInputAudioBufferSpeechStarted
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_1516
        /// </summary>
        /// <example>event_1516</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "input_audio_buffer.speech_started".<br/>
        /// Example: input_audio_buffer.speech_started
        /// </summary>
        /// <example>input_audio_buffer.speech_started</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeInputAudioBufferSpeechStartedTypeJsonConverter))]
        public global::OpenAI.RealtimeInputAudioBufferSpeechStartedType? Type { get; set; }

        /// <summary>
        /// Milliseconds since the session started when speech was detected.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_ms")]
        public int? AudioStartMs { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created when speech stops.<br/>
        /// Example: msg_003
        /// </summary>
        /// <example>msg_003</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferSpeechStarted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_1516
        /// </param>
        /// <param name="type">
        /// The event type, must be "input_audio_buffer.speech_started".<br/>
        /// Example: input_audio_buffer.speech_started
        /// </param>
        /// <param name="audioStartMs">
        /// Milliseconds since the session started when speech was detected.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created when speech stops.<br/>
        /// Example: msg_003
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeInputAudioBufferSpeechStarted(
            string? eventId,
            global::OpenAI.RealtimeInputAudioBufferSpeechStartedType? type,
            int? audioStartMs,
            string? itemId)
        {
            this.EventId = eventId;
            this.Type = type;
            this.AudioStartMs = audioStartMs;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferSpeechStarted" /> class.
        /// </summary>
        public RealtimeInputAudioBufferSpeechStarted()
        {
        }
    }
}