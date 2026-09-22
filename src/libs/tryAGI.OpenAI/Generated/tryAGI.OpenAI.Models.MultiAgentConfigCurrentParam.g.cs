
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Explicit configuration for creating and coordinating subagents.
    /// </summary>
    public sealed partial class MultiAgentConfigCurrentParam
    {
        /// <summary>
        /// Whether subagent tools are enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Maximum number of subagents that may run concurrently. Defaults to 6.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_subagents")]
        public long? MaxConcurrentSubagents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiAgentConfigCurrentParam" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether subagent tools are enabled.
        /// </param>
        /// <param name="maxConcurrentSubagents">
        /// Maximum number of subagents that may run concurrently. Defaults to 6.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiAgentConfigCurrentParam(
            bool enabled,
            long? maxConcurrentSubagents)
        {
            this.Enabled = enabled;
            this.MaxConcurrentSubagents = maxConcurrentSubagents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiAgentConfigCurrentParam" /> class.
        /// </summary>
        public MultiAgentConfigCurrentParam()
        {
        }

    }
}