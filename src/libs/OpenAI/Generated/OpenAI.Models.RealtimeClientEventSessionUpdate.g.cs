
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Send this event to update the session’s default configuration. The client may send this event at any time to update the session configuration, and any field may be updated at any time, except for "voice". The server will respond with a `session.updated` event that shows the full effective configuration. Only fields that are present are updated, thus the correct way to clear a field like "instructions" is to pass an empty string.
    /// </summary>
    public sealed partial class RealtimeClientEventSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "session.update".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

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
        public required global::OpenAI.RealtimeSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventSessionUpdate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be "session.update".
        /// </param>
        /// <param name="session">
        /// A session refers to a single WebSocket connection between a client and the server.<br/>
        /// Once a client creates a session, it then sends JSON-formatted events containing text and audio chunks.<br/>
        /// The server will respond in kind with audio containing voice output, a text transcript of that voice output,<br/>
        /// and function calls (if functions are provided by the client).<br/>
        /// A realtime Session represents the overall client-server interaction, and contains default configuration.<br/>
        /// It has a set of default values which can be updated at any time (via session.update) or on a per-response level (via response.create).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeClientEventSessionUpdate(
            string type,
            global::OpenAI.RealtimeSession session,
            string? eventId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventSessionUpdate" /> class.
        /// </summary>
        public RealtimeClientEventSessionUpdate()
        {
        }
    }
}