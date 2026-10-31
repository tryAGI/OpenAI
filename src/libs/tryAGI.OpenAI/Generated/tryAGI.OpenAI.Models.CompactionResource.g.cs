
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The effective settings for compacting the agent's context.
    /// </summary>
    public sealed partial class CompactionResource
    {
        /// <summary>
        /// Whether context is compacted in the background. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Async { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionResource" /> class.
        /// </summary>
        /// <param name="async">
        /// Whether context is compacted in the background. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionResource(
            bool async)
        {
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionResource" /> class.
        /// </summary>
        public CompactionResource()
        {
        }

    }
}