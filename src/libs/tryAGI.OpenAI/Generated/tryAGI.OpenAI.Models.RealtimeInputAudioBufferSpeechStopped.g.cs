
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned in server turn detection mode when speech stops.
    /// </summary>
    public sealed partial class RealtimeInputAudioBufferSpeechStopped
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_1718
        /// </summary>
        /// <example>event_1718</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "input_audio_buffer.speech_stopped".<br/>
        /// Example: input_audio_buffer.speech_stopped
        /// </summary>
        /// <example>input_audio_buffer.speech_stopped</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeInputAudioBufferSpeechStoppedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeInputAudioBufferSpeechStoppedType? Type { get; set; }

        /// <summary>
        /// Milliseconds since the session started when speech stopped.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        public int? AudioEndMs { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.<br/>
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
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferSpeechStopped" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_1718
        /// </param>
        /// <param name="type">
        /// The event type, must be "input_audio_buffer.speech_stopped".<br/>
        /// Example: input_audio_buffer.speech_stopped
        /// </param>
        /// <param name="audioEndMs">
        /// Milliseconds since the session started when speech stopped.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created.<br/>
        /// Example: msg_003
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeInputAudioBufferSpeechStopped(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeInputAudioBufferSpeechStoppedType? type,
            int? audioEndMs,
            string? itemId)
        {
            this.EventId = eventId;
            this.Type = type;
            this.AudioEndMs = audioEndMs;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferSpeechStopped" /> class.
        /// </summary>
        public RealtimeInputAudioBufferSpeechStopped()
        {
        }
    }
}