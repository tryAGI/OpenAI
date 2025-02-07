
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to append audio bytes to the input audio buffer.
    /// </summary>
    public sealed partial class RealtimeInputAudioBufferAppend
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_456
        /// </summary>
        /// <example>event_456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "input_audio_buffer.append".<br/>
        /// Example: input_audio_buffer.append
        /// </summary>
        /// <example>input_audio_buffer.append</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeInputAudioBufferAppendTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeInputAudioBufferAppendType? Type { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes.<br/>
        /// Example: Base64EncodedAudioData
        /// </summary>
        /// <example>Base64EncodedAudioData</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferAppend" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_456
        /// </param>
        /// <param name="type">
        /// The event type, must be "input_audio_buffer.append".<br/>
        /// Example: input_audio_buffer.append
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio bytes.<br/>
        /// Example: Base64EncodedAudioData
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeInputAudioBufferAppend(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeInputAudioBufferAppendType? type,
            string? audio)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferAppend" /> class.
        /// </summary>
        public RealtimeInputAudioBufferAppend()
        {
        }
    }
}