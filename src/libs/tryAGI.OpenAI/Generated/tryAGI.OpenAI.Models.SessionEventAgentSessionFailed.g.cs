
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a session fails.
    /// </summary>
    public sealed partial class SessionEventAgentSessionFailed
    {
        /// <summary>
        /// The type of the object. Always `agent.session.failed`.<br/>
        /// Default Value: agent.session.failed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionFailedType.AgentSessionFailed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionFailedTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionFailedType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionFailedType.AgentSessionFailed;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The failed session.
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
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionFailed" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="session">
        /// The failed session.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.failed`.<br/>
        /// Default Value: agent.session.failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionFailed(
            string eventId,
            global::tryAGI.OpenAI.SessionResource session,
            global::tryAGI.OpenAI.SessionEventAgentSessionFailedType type = global::tryAGI.OpenAI.SessionEventAgentSessionFailedType.AgentSessionFailed)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionFailed" /> class.
        /// </summary>
        public SessionEventAgentSessionFailed()
        {
        }

    }
}