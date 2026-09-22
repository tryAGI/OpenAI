
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The latest measured context-window usage of the Live model. This is separate from billing usage and delegated Responses token usage.
    /// </summary>
    public sealed partial class LiveContextWindowUsage
    {
        /// <summary>
        /// The latest active context token count divided by the Live model context limit. Can decrease after compaction and may lag between measured audio frames.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveContextWindowUsage" /> class.
        /// </summary>
        /// <param name="usageRatio">
        /// The latest active context token count divided by the Live model context limit. Can decrease after compaction and may lag between measured audio frames.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveContextWindowUsage(
            double usageRatio)
        {
            this.UsageRatio = usageRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveContextWindowUsage" /> class.
        /// </summary>
        public LiveContextWindowUsage()
        {
        }

    }
}