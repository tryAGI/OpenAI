
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a subagent is closed.
    /// </summary>
    public sealed partial class SessionEventAgentSessionSubagentClosed
    {
        /// <summary>
        /// The type of the object. Always `agent.session.subagent.closed`.<br/>
        /// Default Value: agent.session.subagent.closed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType.AgentSessionSubagentClosed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentClosedTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType.AgentSessionSubagentClosed;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The subagent that was closed.
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
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionSubagentClosed" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="subagent">
        /// The subagent that was closed.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.subagent.closed`.<br/>
        /// Default Value: agent.session.subagent.closed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionSubagentClosed(
            string eventId,
            global::tryAGI.OpenAI.SubagentResource subagent,
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType type = global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType.AgentSessionSubagentClosed)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Subagent = subagent ?? throw new global::System.ArgumentNullException(nameof(subagent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionSubagentClosed" /> class.
        /// </summary>
        public SessionEventAgentSessionSubagentClosed()
        {
        }

    }
}