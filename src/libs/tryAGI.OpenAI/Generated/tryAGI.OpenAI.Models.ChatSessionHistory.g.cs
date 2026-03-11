
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// History retention preferences returned for the session.
    /// </summary>
    public sealed partial class ChatSessionHistory
    {
        /// <summary>
        /// Indicates if chat history is persisted for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_threads")]
        public int? RecentThreads { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionHistory" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates if chat history is persisted for the session.
        /// </param>
        /// <param name="recentThreads"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSessionHistory(
            bool enabled,
            int? recentThreads)
        {
            this.Enabled = enabled;
            this.RecentThreads = recentThreads;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionHistory" /> class.
        /// </summary>
        public ChatSessionHistory()
        {
        }
    }
}