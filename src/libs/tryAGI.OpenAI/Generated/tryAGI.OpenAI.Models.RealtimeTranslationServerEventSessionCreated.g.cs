
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a translation session is created. Emitted automatically when a<br/>
    /// new connection is established as the first server event. This event contains<br/>
    /// the default translation session configuration.
    /// </summary>
    public sealed partial class RealtimeTranslationServerEventSessionCreated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType Type { get; set; }

        /// <summary>
        /// The translation session configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeTranslationSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationServerEventSessionCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="session">
        /// The translation session configuration.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationServerEventSessionCreated(
            string eventId,
            global::tryAGI.OpenAI.RealtimeTranslationSession session,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionCreatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationServerEventSessionCreated" /> class.
        /// </summary>
        public RealtimeTranslationServerEventSessionCreated()
        {
        }
    }
}