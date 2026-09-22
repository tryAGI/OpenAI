
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The resolved configuration for creating and coordinating subagents.
    /// </summary>
    public sealed partial class MultiAgentConfigResource
    {
        /// <summary>
        /// Whether subagent tools are enabled. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Maximum number of subagents that may run concurrently, or null when disabled. Defaults to 6 when enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_subagents")]
        public long? MaxConcurrentSubagents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiAgentConfigResource" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether subagent tools are enabled. Defaults to false.
        /// </param>
        /// <param name="maxConcurrentSubagents">
        /// Maximum number of subagents that may run concurrently, or null when disabled. Defaults to 6 when enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiAgentConfigResource(
            bool enabled,
            long? maxConcurrentSubagents)
        {
            this.Enabled = enabled;
            this.MaxConcurrentSubagents = maxConcurrentSubagents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiAgentConfigResource" /> class.
        /// </summary>
        public MultiAgentConfigResource()
        {
        }

    }
}