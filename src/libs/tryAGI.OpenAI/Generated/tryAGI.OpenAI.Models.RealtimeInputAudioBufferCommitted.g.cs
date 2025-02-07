
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an input audio buffer is committed, either by the client or automatically in server VAD mode.
    /// </summary>
    public sealed partial class RealtimeInputAudioBufferCommitted
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_1121
        /// </summary>
        /// <example>event_1121</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "input_audio_buffer.committed".<br/>
        /// Example: input_audio_buffer.committed
        /// </summary>
        /// <example>input_audio_buffer.committed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeInputAudioBufferCommittedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeInputAudioBufferCommittedType? Type { get; set; }

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted.<br/>
        /// Example: msg_001
        /// </summary>
        /// <example>msg_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.<br/>
        /// Example: msg_002
        /// </summary>
        /// <example>msg_002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferCommitted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_1121
        /// </param>
        /// <param name="type">
        /// The event type, must be "input_audio_buffer.committed".<br/>
        /// Example: input_audio_buffer.committed
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item after which the new item will be inserted.<br/>
        /// Example: msg_001
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created.<br/>
        /// Example: msg_002
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeInputAudioBufferCommitted(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeInputAudioBufferCommittedType? type,
            string? previousItemId,
            string? itemId)
        {
            this.EventId = eventId;
            this.Type = type;
            this.PreviousItemId = previousItemId;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputAudioBufferCommitted" /> class.
        /// </summary>
        public RealtimeInputAudioBufferCommitted()
        {
        }
    }
}