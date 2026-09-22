
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for creating a reusable agent.
    /// </summary>
    public sealed partial class CreateAgentParams
    {
        /// <summary>
        /// Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Omission or null defaults to an empty map.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// A human-readable name for the agent. Omission or null leaves the agent unnamed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The model to use for the agent. The requested model name is preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Configuration for model reasoning. Omission uses the model's default effort.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.ReasoningParam? Reasoning { get; set; }

        /// <summary>
        /// Configuration for generated text. Defaults to the `text` format and medium verbosity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::tryAGI.OpenAI.TextParam? Text { get; set; }

        /// <summary>
        /// The service tier used for model requests. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::tryAGI.OpenAI.ServiceTierParam? ServiceTier { get; set; }

        /// <summary>
        /// Additional instructions appended to the agent's default base instructions. Omit or set to null to add no custom instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Tools available to the agent. Defaults to an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? Tools { get; set; }

        /// <summary>
        /// Configuration for creating and coordinating subagents. Subagent tools are disabled by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_agent")]
        public global::tryAGI.OpenAI.MultiAgentConfigCurrentParam? MultiAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentParams" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for the agent. The requested model name is preserved.
        /// </param>
        /// <param name="metadata">
        /// Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Omission or null defaults to an empty map.
        /// </param>
        /// <param name="name">
        /// A human-readable name for the agent. Omission or null leaves the agent unnamed.
        /// </param>
        /// <param name="reasoning">
        /// Configuration for model reasoning. Omission uses the model's default effort.
        /// </param>
        /// <param name="text">
        /// Configuration for generated text. Defaults to the `text` format and medium verbosity.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used for model requests. Defaults to `auto`.
        /// </param>
        /// <param name="instructions">
        /// Additional instructions appended to the agent's default base instructions. Omit or set to null to add no custom instructions.
        /// </param>
        /// <param name="tools">
        /// Tools available to the agent. Defaults to an empty list.
        /// </param>
        /// <param name="multiAgent">
        /// Configuration for creating and coordinating subagents. Subagent tools are disabled by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentParams(
            string model,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? name,
            global::tryAGI.OpenAI.ReasoningParam? reasoning,
            global::tryAGI.OpenAI.TextParam? text,
            global::tryAGI.OpenAI.ServiceTierParam? serviceTier,
            string? instructions,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? tools,
            global::tryAGI.OpenAI.MultiAgentConfigCurrentParam? multiAgent)
        {
            this.Metadata = metadata;
            this.Name = name;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Reasoning = reasoning;
            this.Text = text;
            this.ServiceTier = serviceTier;
            this.Instructions = instructions;
            this.Tools = tools;
            this.MultiAgent = multiAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentParams" /> class.
        /// </summary>
        public CreateAgentParams()
        {
        }

    }
}