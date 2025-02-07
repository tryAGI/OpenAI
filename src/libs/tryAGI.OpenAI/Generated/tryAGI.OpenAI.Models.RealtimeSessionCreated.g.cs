
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a session is created. Emitted automatically when a new connection is established.
    /// </summary>
    public sealed partial class RealtimeSessionCreated
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_1234
        /// </summary>
        /// <example>event_1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "session.created".<br/>
        /// Example: session.created
        /// </summary>
        /// <example>session.created</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionCreatedType? Type { get; set; }

        /// <summary>
        /// A session refers to a single WebSocket connection between a client and the server.<br/>
        /// Once a client creates a session, it then sends JSON-formatted events containing text and audio chunks.<br/>
        /// The server will respond in kind with audio containing voice output, a text transcript of that voice output,<br/>
        /// and function calls (if functions are provided by the client).<br/>
        /// A realtime Session represents the overall client-server interaction, and contains default configuration.<br/>
        /// It has a set of default values which can be updated at any time (via session.update) or on a per-response level (via response.create).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::tryAGI.OpenAI.RealtimeSession? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_1234
        /// </param>
        /// <param name="type">
        /// The event type, must be "session.created".<br/>
        /// Example: session.created
        /// </param>
        /// <param name="session">
        /// A session refers to a single WebSocket connection between a client and the server.<br/>
        /// Once a client creates a session, it then sends JSON-formatted events containing text and audio chunks.<br/>
        /// The server will respond in kind with audio containing voice output, a text transcript of that voice output,<br/>
        /// and function calls (if functions are provided by the client).<br/>
        /// A realtime Session represents the overall client-server interaction, and contains default configuration.<br/>
        /// It has a set of default values which can be updated at any time (via session.update) or on a per-response level (via response.create).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreated(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeSessionCreatedType? type,
            global::tryAGI.OpenAI.RealtimeSession? session)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreated" /> class.
        /// </summary>
        public RealtimeSessionCreated()
        {
        }
    }
}