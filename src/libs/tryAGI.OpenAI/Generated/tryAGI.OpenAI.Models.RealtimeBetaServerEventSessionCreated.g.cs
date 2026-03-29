
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a Session is created. Emitted automatically when a new<br/>
    /// connection is established as the first server event. This event will contain<br/>
    /// the default Session configuration.
    /// </summary>
    public sealed partial class RealtimeBetaServerEventSessionCreated
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventSessionCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType Type { get; set; }

        /// <summary>
        /// Realtime session object for the beta interface.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventSessionCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="session">
        /// Realtime session object for the beta interface.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.created`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaServerEventSessionCreated(
            string eventId,
            global::tryAGI.OpenAI.RealtimeSession session,
            global::tryAGI.OpenAI.RealtimeBetaServerEventSessionCreatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventSessionCreated" /> class.
        /// </summary>
        public RealtimeBetaServerEventSessionCreated()
        {
        }
    }
}