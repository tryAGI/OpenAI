
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
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `minimal`, `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningEffortJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningEffort? Effort { get; set; }

        /// <summary>
        /// **Deprecated:** use `summary` instead.<br/>
        /// A summary of the reasoning performed by the model. This can be<br/>
        /// useful for debugging and understanding the model's reasoning process.<br/>
        /// One of `auto`, `concise`, or `detailed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummaryJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.ReasoningGenerateSummary? GenerateSummary { get; set; }

        /// <summary>
        /// A summary of the reasoning performed by the model. This can be<br/>
        /// useful for debugging and understanding the model's reasoning process.<br/>
        /// One of `auto`, `concise`, or `detailed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `minimal`, `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="summary">
        /// A summary of the reasoning performed by the model. This can be<br/>
        /// useful for debugging and understanding the model's reasoning process.<br/>
        /// One of `auto`, `concise`, or `detailed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Reasoning(
            global::tryAGI.OpenAI.ReasoningEffort? effort,
            global::tryAGI.OpenAI.ReasoningSummary? summary)
        {
            this.Effort = effort;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reasoning" /> class.
        /// </summary>
        public Reasoning()
        {
        }
    }
}