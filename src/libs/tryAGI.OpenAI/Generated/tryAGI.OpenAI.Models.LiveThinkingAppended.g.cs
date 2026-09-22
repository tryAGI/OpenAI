
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a session.thinking.append command is accepted into the Live session timeline. Acknowledges the added reasoning context without guaranteeing any spoken output.<br/>
    /// Example: {"type":"session.thinking.appended","event_id":"evt_thinking_002","client_event_id":"evt_thinking_001","start_ms":4600,"end_ms":4800}
    /// </summary>
    public sealed partial class LiveThinkingAppended
    {
        /// <summary>
        /// The unique ID of the Live server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event_id of the client command associated with this server event, when supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// The start of this event on the Live session timeline, in milliseconds from the beginning of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartMs { get; set; }

        /// <summary>
        /// The end of this event on the Live session timeline, in milliseconds from the beginning of the session. For appended context, this can equal start_ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndMs { get; set; }

        /// <summary>
        /// The event type, always `session.thinking.appended`.<br/>
        /// Default Value: session.thinking.appended
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveThinkingAppendedType.SessionThinkingAppended</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveThinkingAppendedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveThinkingAppendedType Type { get; set; } = global::tryAGI.OpenAI.LiveThinkingAppendedType.SessionThinkingAppended;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveThinkingAppended" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="startMs">
        /// The start of this event on the Live session timeline, in milliseconds from the beginning of the session.
        /// </param>
        /// <param name="endMs">
        /// The end of this event on the Live session timeline, in milliseconds from the beginning of the session. For appended context, this can equal start_ms.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.thinking.appended`.<br/>
        /// Default Value: session.thinking.appended
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveThinkingAppended(
            string eventId,
            int startMs,
            int endMs,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveThinkingAppendedType type = global::tryAGI.OpenAI.LiveThinkingAppendedType.SessionThinkingAppended)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveThinkingAppended" /> class.
        /// </summary>
        public LiveThinkingAppended()
        {
        }

    }
}