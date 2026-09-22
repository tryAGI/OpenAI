
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a session is created.
    /// </summary>
    public sealed partial class SessionEventAgentSessionCreated
    {
        /// <summary>
        /// The type of the object. Always `agent.session.created`.<br/>
        /// Default Value: agent.session.created
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType.AgentSessionCreated</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType.AgentSessionCreated;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The session that was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionResource Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="session">
        /// The session that was created.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.created`.<br/>
        /// Default Value: agent.session.created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionCreated(
            string eventId,
            global::tryAGI.OpenAI.SessionResource session,
            global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType type = global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType.AgentSessionCreated)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionCreated" /> class.
        /// </summary>
        public SessionEventAgentSessionCreated()
        {
        }

    }
}