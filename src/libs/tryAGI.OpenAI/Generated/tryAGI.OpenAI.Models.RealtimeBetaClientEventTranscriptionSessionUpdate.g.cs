
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
        /// The event type, must be `transcription_session.update`.
        /// </summary>
        /// <default>"transcription_session.update"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "transcription_session.update";

        /// <summary>
        /// Realtime transcription session object configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaClientEventTranscriptionSessionUpdate" /> class.
        /// </summary>
        /// <param name="session">
        /// Realtime transcription session object configuration.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
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
            string type = "transcription_session.update")
        {
            this.EventId = eventId;
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaClientEventTranscriptionSessionUpdate" /> class.
        /// </summary>
        public RealtimeBetaClientEventTranscriptionSessionUpdate()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RealtimeBetaClientEventTranscriptionSessionUpdate"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RealtimeBetaClientEventTranscriptionSessionUpdate FromSession(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest session)
        {
            return new RealtimeBetaClientEventTranscriptionSessionUpdate
            {
                Session = session,
            };
        }

    }
}