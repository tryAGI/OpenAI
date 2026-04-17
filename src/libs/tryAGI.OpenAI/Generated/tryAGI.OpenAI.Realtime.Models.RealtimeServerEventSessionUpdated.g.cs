
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Returned when a session is updated with a `session.update` event, unless<br/>
    /// there is an error.
    /// </summary>
    public sealed partial class RealtimeServerEventSessionUpdated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.updated`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeServerEventSessionUpdatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdatedType Type { get; set; }

        /// <summary>
        /// The session configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA> Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventSessionUpdated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="session">
        /// The session configuration.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.updated`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventSessionUpdated(
            string eventId,
            global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGA> session,
            global::tryAGI.OpenAI.Realtime.RealtimeServerEventSessionUpdatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventSessionUpdated" /> class.
        /// </summary>
        public RealtimeServerEventSessionUpdated()
        {
        }
    }
}