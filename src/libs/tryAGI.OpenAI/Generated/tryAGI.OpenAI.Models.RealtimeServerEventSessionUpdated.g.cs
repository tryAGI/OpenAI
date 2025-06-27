
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a session is updated with a `session.update` event, unless <br/>
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
        /// A session refers to a single WebSocket connection between a client and the server.<br/>
        /// Once a client creates a session, it then sends JSON-formatted events containing text and audio chunks.<br/>
        /// The server will respond in kind with audio containing voice output, a text transcript of that voice output,<br/>
        /// and function calls (if functions are provided by the client).<br/>
        /// A realtime Session represents the overall client-server interaction, and contains default configuration.<br/>
        /// It has a set of default values which can be updated at any time (via session.update) or on a per-response level (via response.create).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeSession Session { get; set; }

        /// <summary>
        /// The event type, must be `session.updated`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventSessionUpdatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType Type { get; set; }

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
        /// A session refers to a single WebSocket connection between a client and the server.<br/>
        /// Once a client creates a session, it then sends JSON-formatted events containing text and audio chunks.<br/>
        /// The server will respond in kind with audio containing voice output, a text transcript of that voice output,<br/>
        /// and function calls (if functions are provided by the client).<br/>
        /// A realtime Session represents the overall client-server interaction, and contains default configuration.<br/>
        /// It has a set of default values which can be updated at any time (via session.update) or on a per-response level (via response.create).
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.updated`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventSessionUpdated(
            string eventId,
            global::tryAGI.OpenAI.RealtimeSession session,
            global::tryAGI.OpenAI.RealtimeServerEventSessionUpdatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventSessionUpdated" /> class.
        /// </summary>
        public RealtimeServerEventSessionUpdated()
        {
        }
    }
}