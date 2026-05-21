
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to update the translation session configuration. Translation<br/>
    /// sessions support updates to `audio.output.language`, `audio.input.transcription`,<br/>
    /// and `audio.input.noise_reduction`.
    /// </summary>
    public sealed partial class RealtimeTranslationClientEventSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.update`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationClientEventSessionUpdateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdateType Type { get; set; }

        /// <summary>
        /// Translation session fields to update. The session `type` and `model` are set<br/>
        /// at creation and cannot be changed with `session.update`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequest Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientEventSessionUpdate" /> class.
        /// </summary>
        /// <param name="session">
        /// Translation session fields to update. The session `type` and `model` are set<br/>
        /// at creation and cannot be changed with `session.update`.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.update`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationClientEventSessionUpdate(
            global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequest session,
            string? eventId,
            global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdateType type)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientEventSessionUpdate" /> class.
        /// </summary>
        public RealtimeTranslationClientEventSessionUpdate()
        {
        }

    }
}