
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to clear the audio bytes in the buffer. The server will <br/>
    /// respond with an `input_audio_buffer.cleared` event.
    /// </summary>
    public sealed partial class RealtimeClientEventInputAudioBufferClear
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.clear`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventInputAudioBufferClearTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventInputAudioBufferClear" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.clear`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeClientEventInputAudioBufferClear(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeClientEventInputAudioBufferClearType type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventInputAudioBufferClear" /> class.
        /// </summary>
        public RealtimeClientEventInputAudioBufferClear()
        {
        }
    }
}