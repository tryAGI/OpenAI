
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// **gpt-5 and o-series models only**<br/>
    /// Configuration options for<br/>
    /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).
    /// </summary>
    public sealed partial class Reasoning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::tryAGI.OpenAI.ReasoningEffortEnum? Effort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::tryAGI.OpenAI.ReasoningSummary2? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_summary")]
        public global::tryAGI.OpenAI.ReasoningGenerateSummary2? GenerateSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reasoning" /> class.
        /// </summary>
        /// <param name="effort"></param>
        /// <param name="summary"></param>
        /// <param name="generateSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Reasoning(
            global::tryAGI.OpenAI.ReasoningEffortEnum? effort,
            global::tryAGI.OpenAI.ReasoningSummary2? summary,
            global::tryAGI.OpenAI.ReasoningGenerateSummary2? generateSummary)
        {
            this.Effort = effort;
            this.Summary = summary;
            this.GenerateSummary = generateSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reasoning" /> class.
        /// </summary>
        public Reasoning()
        {
        }
    }
}