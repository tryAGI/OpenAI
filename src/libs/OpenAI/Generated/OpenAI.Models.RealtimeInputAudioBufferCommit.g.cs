
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Send this event to commit audio bytes to a user message.
    /// </summary>
    public sealed partial class RealtimeInputAudioBufferCommit
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_789
        /// </summary>
        /// <example>event_789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "input_audio_buffer.commit".<br/>
        /// Example: input_audio_buffer.commit
        /// </summary>
        /// <example>input_audio_buffer.commit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeInputAudioBufferCommitTypeJsonConverter))]
        public global::OpenAI.RealtimeInputAudioBufferCommitType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferCommit" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_789
        /// </param>
        /// <param name="type">
        /// The event type, must be "input_audio_buffer.commit".<br/>
        /// Example: input_audio_buffer.commit
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeInputAudioBufferCommit(
            string? eventId,
            global::OpenAI.RealtimeInputAudioBufferCommitType? type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferCommit" /> class.
        /// </summary>
        public RealtimeInputAudioBufferCommit()
        {
        }
    }
}