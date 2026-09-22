
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The reasoning configuration used by an agent.
    /// </summary>
    public sealed partial class ReasoningResource
    {
        /// <summary>
        /// The requested reasoning effort, or `null` when the model selects its own default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::tryAGI.OpenAI.ReasoningEffortResource? Effort { get; set; }

        /// <summary>
        /// The requested reasoning summary format, or `null` when summaries are disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::tryAGI.OpenAI.ReasoningSummaryResource? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningResource" /> class.
        /// </summary>
        /// <param name="effort">
        /// The requested reasoning effort, or `null` when the model selects its own default.
        /// </param>
        /// <param name="summary">
        /// The requested reasoning summary format, or `null` when summaries are disabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningResource(
            global::tryAGI.OpenAI.ReasoningEffortResource? effort,
            global::tryAGI.OpenAI.ReasoningSummaryResource? summary)
        {
            this.Effort = effort;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningResource" /> class.
        /// </summary>
        public ReasoningResource()
        {
        }

    }
}