
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a session becomes idle.
    /// </summary>
    public sealed partial class SessionEventAgentSessionIdle
    {
        /// <summary>
        /// The type of the object. Always `agent.session.idle`.<br/>
        /// Default Value: agent.session.idle
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionIdleType.AgentSessionIdle</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionIdleTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionIdleType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionIdleType.AgentSessionIdle;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The session that became idle.
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
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionIdle" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="session">
        /// The session that became idle.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.idle`.<br/>
        /// Default Value: agent.session.idle
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionIdle(
            string eventId,
            global::tryAGI.OpenAI.SessionResource session,
            global::tryAGI.OpenAI.SessionEventAgentSessionIdleType type = global::tryAGI.OpenAI.SessionEventAgentSessionIdleType.AgentSessionIdle)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionIdle" /> class.
        /// </summary>
        public SessionEventAgentSessionIdle()
        {
        }

    }
}