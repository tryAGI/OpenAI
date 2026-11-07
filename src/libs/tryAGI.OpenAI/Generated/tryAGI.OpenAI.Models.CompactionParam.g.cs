
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Settings for compacting the agent's context.
    /// </summary>
    public sealed partial class CompactionParam
    {
        /// <summary>
        /// Whether to compact context in the background. Omission or null defaults to true. Set to false to use blocking compaction. Background compaction may increase token usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionParam" /> class.
        /// </summary>
        /// <param name="async">
        /// Whether to compact context in the background. Omission or null defaults to true. Set to false to use blocking compaction. Background compaction may increase token usage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionParam(
            bool? async)
        {
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionParam" /> class.
        /// </summary>
        public CompactionParam()
        {
        }

    }
}