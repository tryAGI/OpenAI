
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Inline agent configuration without a generated session-local identity.
    /// </summary>
    public sealed partial class AutomationAgentConfigResource
    {
        /// <summary>
        /// The requested model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The configured reasoning policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ReasoningResource Reasoning { get; set; }

        /// <summary>
        /// The configured output format and verbosity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.TextResource Text { get; set; }

        /// <summary>
        /// The configured service-tier policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ServiceTierResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ServiceTierResource ServiceTier { get; set; }

        /// <summary>
        /// Custom instructions, or null when absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Configured tools, excluding confidential credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource> Tools { get; set; }

        /// <summary>
        /// The configuration for creating and coordinating subagents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MultiAgentConfigResource MultiAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationAgentConfigResource" /> class.
        /// </summary>
        /// <param name="model">
        /// The requested model name.
        /// </param>
        /// <param name="reasoning">
        /// The configured reasoning policy.
        /// </param>
        /// <param name="text">
        /// The configured output format and verbosity.
        /// </param>
        /// <param name="serviceTier">
        /// The configured service-tier policy.
        /// </param>
        /// <param name="tools">
        /// Configured tools, excluding confidential credentials.
        /// </param>
        /// <param name="multiAgent">
        /// The configuration for creating and coordinating subagents.
        /// </param>
        /// <param name="instructions">
        /// Custom instructions, or null when absent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationAgentConfigResource(
            string model,
            global::tryAGI.OpenAI.ReasoningResource reasoning,
            global::tryAGI.OpenAI.TextResource text,
            global::tryAGI.OpenAI.ServiceTierResource serviceTier,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource> tools,
            global::tryAGI.OpenAI.MultiAgentConfigResource multiAgent,
            string? instructions)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ServiceTier = serviceTier;
            this.Instructions = instructions;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.MultiAgent = multiAgent ?? throw new global::System.ArgumentNullException(nameof(multiAgent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationAgentConfigResource" /> class.
        /// </summary>
        public AutomationAgentConfigResource()
        {
        }

    }
}