
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a subagent is created.
    /// </summary>
    public sealed partial class SessionEventAgentSessionSubagentCreated
    {
        /// <summary>
        /// The type of the object. Always `agent.session.subagent.created`.<br/>
        /// Default Value: agent.session.subagent.created
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType.AgentSessionSubagentCreated</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType.AgentSessionSubagentCreated;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The subagent that was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SubagentResource Subagent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionSubagentCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="subagent">
        /// The subagent that was created.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.subagent.created`.<br/>
        /// Default Value: agent.session.subagent.created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionSubagentCreated(
            string eventId,
            global::tryAGI.OpenAI.SubagentResource subagent,
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType type = global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType.AgentSessionSubagentCreated)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Subagent = subagent ?? throw new global::System.ArgumentNullException(nameof(subagent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionSubagentCreated" /> class.
        /// </summary>
        public SessionEventAgentSessionSubagentCreated()
        {
        }

    }
}