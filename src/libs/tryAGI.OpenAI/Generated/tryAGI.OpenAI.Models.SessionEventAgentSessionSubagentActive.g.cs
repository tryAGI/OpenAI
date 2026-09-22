
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a closed subagent successfully resumes.
    /// </summary>
    public sealed partial class SessionEventAgentSessionSubagentActive
    {
        /// <summary>
        /// The type of the object. Always `agent.session.subagent.active`.<br/>
        /// Default Value: agent.session.subagent.active
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType.AgentSessionSubagentActive</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentActiveTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType.AgentSessionSubagentActive;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The subagent that resumed.
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
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionSubagentActive" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="subagent">
        /// The subagent that resumed.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.subagent.active`.<br/>
        /// Default Value: agent.session.subagent.active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionSubagentActive(
            string eventId,
            global::tryAGI.OpenAI.SubagentResource subagent,
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType type = global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType.AgentSessionSubagentActive)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Subagent = subagent ?? throw new global::System.ArgumentNullException(nameof(subagent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionSubagentActive" /> class.
        /// </summary>
        public SessionEventAgentSessionSubagentActive()
        {
        }

    }
}