
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationTargetResourceNewSession
    {
        /// <summary>
        /// The type of the object. Always `new_session`.<br/>
        /// Default Value: new_session
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AutomationTargetResourceNewSessionType.NewSession</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationTargetResourceNewSessionTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutomationTargetResourceNewSessionType Type { get; set; } = global::tryAGI.OpenAI.AutomationTargetResourceNewSessionType.NewSession;

        /// <summary>
        /// The saved agent reference, or null when an inline agent is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The inline agent configuration, or null when agent_id is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.AutomationAgentConfigResource? Agent { get; set; }

        /// <summary>
        /// Configuration or references used to select the execution environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutomationEnvironmentResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AutomationEnvironmentResource Environment { get; set; }

        /// <summary>
        /// Initial input delivered to each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageResource2> Input { get; set; }

        /// <summary>
        /// Vaults made available to each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VaultIds { get; set; }

        /// <summary>
        /// Metadata attached to each new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTargetResourceNewSession" /> class.
        /// </summary>
        /// <param name="environment">
        /// Configuration or references used to select the execution environment.
        /// </param>
        /// <param name="input">
        /// Initial input delivered to each new session.
        /// </param>
        /// <param name="vaultIds">
        /// Vaults made available to each new session.
        /// </param>
        /// <param name="metadata">
        /// Metadata attached to each new session.
        /// </param>
        /// <param name="agentId">
        /// The saved agent reference, or null when an inline agent is configured.
        /// </param>
        /// <param name="agent">
        /// The inline agent configuration, or null when agent_id is configured.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `new_session`.<br/>
        /// Default Value: new_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationTargetResourceNewSession(
            global::tryAGI.OpenAI.AutomationEnvironmentResource environment,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageResource2> input,
            global::System.Collections.Generic.IList<string> vaultIds,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            string? agentId,
            global::tryAGI.OpenAI.AutomationAgentConfigResource? agent,
            global::tryAGI.OpenAI.AutomationTargetResourceNewSessionType type = global::tryAGI.OpenAI.AutomationTargetResourceNewSessionType.NewSession)
        {
            this.Type = type;
            this.AgentId = agentId;
            this.Agent = agent;
            this.Environment = environment;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.VaultIds = vaultIds ?? throw new global::System.ArgumentNullException(nameof(vaultIds));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationTargetResourceNewSession" /> class.
        /// </summary>
        public AutomationTargetResourceNewSession()
        {
        }

    }
}