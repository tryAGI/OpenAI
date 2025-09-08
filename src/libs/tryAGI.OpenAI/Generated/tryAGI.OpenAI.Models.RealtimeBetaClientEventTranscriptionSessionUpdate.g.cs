
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to update a transcription session.
    /// </summary>
    public sealed partial class RealtimeBetaClientEventTranscriptionSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Realtime transcription session object configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest Session { get; set; }

        /// <summary>
        /// The event type, must be `transcription_session.update`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaClientEventTranscriptionSessionUpdateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdateType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaClientEventTranscriptionSessionUpdate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="session">
        /// Realtime transcription session object configuration.
        /// </param>
        /// <param name="type">
        /// The event type, must be `transcription_session.update`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaClientEventTranscriptionSessionUpdate(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest session,
            string? eventId,
            global::tryAGI.OpenAI.RealtimeBetaClientEventTranscriptionSessionUpdateType type)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaClientEventTranscriptionSessionUpdate" /> class.
        /// </summary>
        public RealtimeBetaClientEventTranscriptionSessionUpdate()
        {
        }
    }
}