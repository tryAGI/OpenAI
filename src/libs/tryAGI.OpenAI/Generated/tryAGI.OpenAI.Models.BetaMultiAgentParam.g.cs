
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for server-hosted multi-agent execution.
    /// </summary>
    public sealed partial class BetaMultiAgentParam
    {
        /// <summary>
        /// Whether to enable server-hosted multi-agent execution for this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// `max_concurrent_subagents` sets the maximum number of subagents that can be active simultaneously across the entire agent tree. It includes all descendants—children, grandchildren, and deeper subagents—but excludes the root agent.<br/>
        /// The API does not impose a fixed upper bound on this setting. The default is `3`, which is recommended for most workloads. Multi-agent runs also have no fixed limit on tree depth or the total number of subagents created during a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_subagents")]
        public int? MaxConcurrentSubagents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentParam" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to enable server-hosted multi-agent execution for this response.
        /// </param>
        /// <param name="maxConcurrentSubagents">
        /// `max_concurrent_subagents` sets the maximum number of subagents that can be active simultaneously across the entire agent tree. It includes all descendants—children, grandchildren, and deeper subagents—but excludes the root agent.<br/>
        /// The API does not impose a fixed upper bound on this setting. The default is `3`, which is recommended for most workloads. Multi-agent runs also have no fixed limit on tree depth or the total number of subagents created during a run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMultiAgentParam(
            bool enabled,
            int? maxConcurrentSubagents)
        {
            this.Enabled = enabled;
            this.MaxConcurrentSubagents = maxConcurrentSubagents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMultiAgentParam" /> class.
        /// </summary>
        public BetaMultiAgentParam()
        {
        }

    }
}