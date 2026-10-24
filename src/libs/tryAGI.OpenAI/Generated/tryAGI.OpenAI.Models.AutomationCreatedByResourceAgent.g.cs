
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationCreatedByResourceAgent
    {
        /// <summary>
        /// The type of the object. Always `agent`.<br/>
        /// Default Value: agent
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationCreatedByResourceAgentType.Agent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationCreatedByResourceAgentTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationCreatedByResourceAgentType Type { get; set; } = global::tryAGI.OpenAI.AutomationCreatedByResourceAgentType.Agent;

        /// <summary>
        /// The creator session, which is also the automation's target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The tool call that created the automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationCreatedByResourceAgent" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The creator session, which is also the automation's target.
        /// </param>
        /// <param name="toolCallId">
        /// The tool call that created the automation.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent`.<br/>
        /// Default Value: agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationCreatedByResourceAgent(
            string sessionId,
            string toolCallId,
            global::tryAGI.OpenAI.AutomationCreatedByResourceAgentType type = global::tryAGI.OpenAI.AutomationCreatedByResourceAgentType.Agent)
        {
            this.Type = type;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationCreatedByResourceAgent" /> class.
        /// </summary>
        public AutomationCreatedByResourceAgent()
        {
        }

    }
}