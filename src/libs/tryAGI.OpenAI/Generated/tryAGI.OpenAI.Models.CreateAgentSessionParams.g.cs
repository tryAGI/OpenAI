
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for creating a Managed Agents session.
    /// </summary>
    public sealed partial class CreateAgentSessionParams
    {
        /// <summary>
        /// Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Omission or null defaults to an empty map.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Agent configuration. With `agent_id`, supplied fields override the saved agent for this session. Without `agent_id`, `model` is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.SessionAgentConfigParam? Agent { get; set; }

        /// <summary>
        /// The ID of a saved reusable agent. Omit `agent` to use its configuration unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// An inline execution environment or a reference to an environment template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentParamJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EnvironmentParam Environment { get; set; }

        /// <summary>
        /// The IDs of vaults made available to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_ids")]
        public global::System.Collections.Generic.IList<string>? VaultIds { get; set; }

        /// <summary>
        /// Initial input to submit when the session is created. A string is shorthand for a single user message. Required when `environment.type` is `none`, or when `stream` is `true` for an environment that is not `self_hosted`; optional for self-hosted and non-streaming execution environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.CreateSessionInputParam? Input { get; set; }

        /// <summary>
        /// Whether to stream session events as server-sent events. Defaults to `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionParams" /> class.
        /// </summary>
        /// <param name="environment">
        /// An inline execution environment or a reference to an environment template.
        /// </param>
        /// <param name="metadata">
        /// Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Omission or null defaults to an empty map.
        /// </param>
        /// <param name="agent">
        /// Agent configuration. With `agent_id`, supplied fields override the saved agent for this session. Without `agent_id`, `model` is required.
        /// </param>
        /// <param name="agentId">
        /// The ID of a saved reusable agent. Omit `agent` to use its configuration unchanged.
        /// </param>
        /// <param name="vaultIds">
        /// The IDs of vaults made available to the session.
        /// </param>
        /// <param name="input">
        /// Initial input to submit when the session is created. A string is shorthand for a single user message. Required when `environment.type` is `none`, or when `stream` is `true` for an environment that is not `self_hosted`; optional for self-hosted and non-streaming execution environments.
        /// </param>
        /// <param name="stream">
        /// Whether to stream session events as server-sent events. Defaults to `false`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentSessionParams(
            global::tryAGI.OpenAI.EnvironmentParam environment,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.SessionAgentConfigParam? agent,
            string? agentId,
            global::System.Collections.Generic.IList<string>? vaultIds,
            global::tryAGI.OpenAI.CreateSessionInputParam? input,
            bool? stream)
        {
            this.Metadata = metadata;
            this.Agent = agent;
            this.AgentId = agentId;
            this.Environment = environment;
            this.VaultIds = vaultIds;
            this.Input = input;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionParams" /> class.
        /// </summary>
        public CreateAgentSessionParams()
        {
        }

    }
}