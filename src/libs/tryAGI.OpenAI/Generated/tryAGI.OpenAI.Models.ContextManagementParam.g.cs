
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextManagementParam
    {
        /// <summary>
        /// The context management entry type. Currently only 'compaction' is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_threshold")]
        public int? CompactThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextManagementParam" /> class.
        /// </summary>
        /// <param name="type">
        /// The context management entry type. Currently only 'compaction' is supported.
        /// </param>
        /// <param name="compactThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextManagementParam(
            string type,
            int? compactThreshold)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CompactThreshold = compactThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextManagementParam" /> class.
        /// </summary>
        public ContextManagementParam()
        {
        }
    }
}