
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to clear the audio bytes in the buffer.
    /// </summary>
    public sealed partial class RealtimeInputAudioBufferClear
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_012
        /// </summary>
        /// <example>event_012</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "input_audio_buffer.clear".<br/>
        /// Example: input_audio_buffer.clear
        /// </summary>
        /// <example>input_audio_buffer.clear</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeInputAudioBufferClearTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeInputAudioBufferClearType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferClear" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_012
        /// </param>
        /// <param name="type">
        /// The event type, must be "input_audio_buffer.clear".<br/>
        /// Example: input_audio_buffer.clear
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeInputAudioBufferClear(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeInputAudioBufferClearType? type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferClear" /> class.
        /// </summary>
        public RealtimeInputAudioBufferClear()
        {
        }
    }
}