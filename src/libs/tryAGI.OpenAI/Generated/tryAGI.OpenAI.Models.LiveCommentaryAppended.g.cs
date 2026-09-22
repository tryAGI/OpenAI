
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a session.commentary.append command is accepted into the Live session timeline. Acknowledges the added commentary without guaranteeing exact wording or completed audio playback.<br/>
    /// Example: {"type":"session.commentary.appended","event_id":"evt_commentary_002","client_event_id":"evt_commentary_001","start_ms":5200,"end_ms":5400}
    /// </summary>
    public sealed partial class LiveCommentaryAppended
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
        /// The event type, always `session.commentary.appended`.<br/>
        /// Default Value: session.commentary.appended
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveCommentaryAppendedType.SessionCommentaryAppended</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveCommentaryAppendedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveCommentaryAppendedType Type { get; set; } = global::tryAGI.OpenAI.LiveCommentaryAppendedType.SessionCommentaryAppended;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCommentaryAppended" /> class.
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
        /// The event type, always `session.commentary.appended`.<br/>
        /// Default Value: session.commentary.appended
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveCommentaryAppended(
            string eventId,
            int startMs,
            int endMs,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveCommentaryAppendedType type = global::tryAGI.OpenAI.LiveCommentaryAppendedType.SessionCommentaryAppended)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveCommentaryAppended" /> class.
        /// </summary>
        public LiveCommentaryAppended()
        {
        }

    }
}