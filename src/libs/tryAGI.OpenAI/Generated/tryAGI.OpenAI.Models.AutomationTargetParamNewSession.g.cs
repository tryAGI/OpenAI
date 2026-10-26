
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a session for each invocation.
    /// </summary>
    public sealed partial class AutomationTargetParamNewSession
    {
        /// <summary>
        /// The type of the object. Always `new_session`.<br/>
        /// Default Value: new_session
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationTargetParamNewSessionType.NewSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationTargetParamNewSessionTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationTargetParamNewSessionType Type { get; set; } = global::tryAGI.OpenAI.AutomationTargetParamNewSessionType.NewSession;

        /// <summary>
        /// Inline agent configuration. Provide exactly one of agent and agent_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.SessionAgentConfigParam? Agent { get; set; }

        /// <summary>
        /// A saved agent ID. Provide exactly one of agent and agent_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The execution environment for each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EnvironmentParam Environment { get; set; }

        /// <summary>
        /// Initial user messages submitted with each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam> Input { get; set; }

        /// <summary>
        /// The IDs of vaults made available to each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        public global::System.Collections.Generic.IList<string>? VaultIds { get; set; }

        /// <summary>
        /// Metadata attached to each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTargetParamNewSession" /> class.
        /// </summary>
        /// <param name="environment">
        /// The execution environment for each new session.
        /// </param>
        /// <param name="input">
        /// Initial user messages submitted with each new session.
        /// </param>
        /// <param name="agent">
        /// Inline agent configuration. Provide exactly one of agent and agent_id.
        /// </param>
        /// <param name="agentId">
        /// A saved agent ID. Provide exactly one of agent and agent_id.
        /// </param>
        /// <param name="vaultIds">
        /// The IDs of vaults made available to each new session.
        /// </param>
        /// <param name="metadata">
        /// Metadata attached to each new session.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `new_session`.<br/>
        /// Default Value: new_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationTargetParamNewSession(
            global::tryAGI.OpenAI.EnvironmentParam environment,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam> input,
            global::tryAGI.OpenAI.SessionAgentConfigParam? agent,
            string? agentId,
            global::System.Collections.Generic.IList<string>? vaultIds,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.AutomationTargetParamNewSessionType type = global::tryAGI.OpenAI.AutomationTargetParamNewSessionType.NewSession)
        {
            this.Type = type;
            this.Agent = agent;
            this.AgentId = agentId;
            this.Environment = environment;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.VaultIds = vaultIds;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTargetParamNewSession" /> class.
        /// </summary>
        public AutomationTargetParamNewSession()
        {
        }

    }
}