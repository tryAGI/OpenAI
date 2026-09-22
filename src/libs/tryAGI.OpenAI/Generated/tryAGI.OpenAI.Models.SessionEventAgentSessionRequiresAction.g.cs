
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a session is waiting for one or more required actions.
    /// </summary>
    public sealed partial class SessionEventAgentSessionRequiresAction
    {
        /// <summary>
        /// The type of the object. Always `agent.session.requires_action`.<br/>
        /// Default Value: agent.session.requires_action
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType.AgentSessionRequiresAction</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionRequiresActionTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType.AgentSessionRequiresAction;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The session and its current required actions.
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
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionRequiresAction" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="session">
        /// The session and its current required actions.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.requires_action`.<br/>
        /// Default Value: agent.session.requires_action
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionRequiresAction(
            string eventId,
            global::tryAGI.OpenAI.SessionResource session,
            global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType type = global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType.AgentSessionRequiresAction)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionRequiresAction" /> class.
        /// </summary>
        public SessionEventAgentSessionRequiresAction()
        {
        }

    }
}