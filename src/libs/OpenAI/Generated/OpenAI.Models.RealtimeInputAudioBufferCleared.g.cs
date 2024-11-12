
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Returned when the input audio buffer is cleared by the client.
    /// </summary>
    public sealed partial class RealtimeInputAudioBufferCleared
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_1314
        /// </summary>
        /// <example>event_1314</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "input_audio_buffer.cleared".<br/>
        /// Example: input_audio_buffer.cleared
        /// </summary>
        /// <example>input_audio_buffer.cleared</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeInputAudioBufferClearedTypeJsonConverter))]
        public global::OpenAI.RealtimeInputAudioBufferClearedType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferCleared" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_1314
        /// </param>
        /// <param name="type">
        /// The event type, must be "input_audio_buffer.cleared".<br/>
        /// Example: input_audio_buffer.cleared
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeInputAudioBufferCleared(
            string? eventId,
            global::OpenAI.RealtimeInputAudioBufferClearedType? type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferCleared" /> class.
        /// </summary>
        public RealtimeInputAudioBufferCleared()
        {
        }
    }
}