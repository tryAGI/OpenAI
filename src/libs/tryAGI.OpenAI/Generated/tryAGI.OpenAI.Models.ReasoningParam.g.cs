
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reasoning configuration for the agent.
    /// </summary>
    public sealed partial class ReasoningParam
    {
        /// <summary>
        /// The amount of reasoning effort the model should use. Omission lets the model select it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::tryAGI.OpenAI.ReasoningEffortParam? Effort { get; set; }

        /// <summary>
        /// Controls whether the response includes a reasoning summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::tryAGI.OpenAI.ReasoningSummaryParam? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningParam" /> class.
        /// </summary>
        /// <param name="effort">
        /// The amount of reasoning effort the model should use. Omission lets the model select it.
        /// </param>
        /// <param name="summary">
        /// Controls whether the response includes a reasoning summary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningParam(
            global::tryAGI.OpenAI.ReasoningEffortParam? effort,
            global::tryAGI.OpenAI.ReasoningSummaryParam? summary)
        {
            this.Effort = effort;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningParam" /> class.
        /// </summary>
        public ReasoningParam()
        {
        }

    }
}