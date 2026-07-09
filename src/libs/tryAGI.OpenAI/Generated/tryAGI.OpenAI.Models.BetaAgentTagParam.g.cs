
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The agent that produced this item.
    /// </summary>
    public sealed partial class BetaAgentTagParam
    {
        /// <summary>
        /// The canonical name of the agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAgentTagParam" /> class.
        /// </summary>
        /// <param name="agentName">
        /// The canonical name of the agent that produced this item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAgentTagParam(
            string agentName)
        {
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAgentTagParam" /> class.
        /// </summary>
        public BetaAgentTagParam()
        {
        }

    }
}