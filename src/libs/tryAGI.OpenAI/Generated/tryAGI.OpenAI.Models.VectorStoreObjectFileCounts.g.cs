
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreObjectFileCounts
    {
        /// <summary>
        /// The number of files that are currently being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int InProgress { get; set; } = default!;

        /// <summary>
        /// The number of files that have been successfully processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Completed { get; set; } = default!;

        /// <summary>
        /// The number of files that have failed to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Failed { get; set; } = default!;

        /// <summary>
        /// The number of files that were cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Cancelled { get; set; } = default!;

        /// <summary>
        /// The total number of files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreObjectFileCounts" /> class.
        /// </summary>
        /// <param name="inProgress">
        /// The number of files that are currently being processed.
        /// </param>
        /// <param name="completed">
        /// The number of files that have been successfully processed.
        /// </param>
        /// <param name="failed">
        /// The number of files that have failed to process.
        /// </param>
        /// <param name="cancelled">
        /// The number of files that were cancelled.
        /// </param>
        /// <param name="total">
        /// The total number of files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreObjectFileCounts(
            int inProgress,
            int completed,
            int failed,
            int cancelled,
            int total)
        {
            this.InProgress = inProgress;
            this.Completed = completed;
            this.Failed = failed;
            this.Cancelled = cancelled;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreObjectFileCounts" /> class.
        /// </summary>
        public VectorStoreObjectFileCounts()
        {
        }
    }
}