
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls how much historical context is retained for the session.
    /// </summary>
    public sealed partial class HistoryParam
    {
        /// <summary>
        /// Enables chat users to access previous ChatKit threads. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Number of recent ChatKit threads users have access to. Defaults to unlimited when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_threads")]
        public int? RecentThreads { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryParam" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enables chat users to access previous ChatKit threads. Defaults to true.
        /// </param>
        /// <param name="recentThreads">
        /// Number of recent ChatKit threads users have access to. Defaults to unlimited when unset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryParam(
            bool? enabled,
            int? recentThreads)
        {
            this.Enabled = enabled;
            this.RecentThreads = recentThreads;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryParam" /> class.
        /// </summary>
        public HistoryParam()
        {
        }
    }
}