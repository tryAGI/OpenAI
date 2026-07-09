
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// **gpt-5 and o-series models only**<br/>
    /// Configuration options for<br/>
    /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).
    /// </summary>
    public sealed partial class BetaReasoning
    {
        /// <summary>
        /// Controls the reasoning execution mode for the request.<br/>
        /// When returned on a response, this is the effective execution mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumJsonConverter))]
        public global::tryAGI.OpenAI.BetaReasoningModeEnum? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::tryAGI.OpenAI.BetaReasoningEffortEnum? Effort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::tryAGI.OpenAI.BetaReasoningSummary2? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::tryAGI.OpenAI.BetaReasoningContext2? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_summary")]
        public global::tryAGI.OpenAI.BetaReasoningGenerateSummary2? GenerateSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaReasoning" /> class.
        /// </summary>
        /// <param name="mode">
        /// Controls the reasoning execution mode for the request.<br/>
        /// When returned on a response, this is the effective execution mode.
        /// </param>
        /// <param name="effort"></param>
        /// <param name="summary"></param>
        /// <param name="context"></param>
        /// <param name="generateSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaReasoning(
            global::tryAGI.OpenAI.BetaReasoningModeEnum? mode,
            global::tryAGI.OpenAI.BetaReasoningEffortEnum? effort,
            global::tryAGI.OpenAI.BetaReasoningSummary2? summary,
            global::tryAGI.OpenAI.BetaReasoningContext2? context,
            global::tryAGI.OpenAI.BetaReasoningGenerateSummary2? generateSummary)
        {
            this.Mode = mode;
            this.Effort = effort;
            this.Summary = summary;
            this.Context = context;
            this.GenerateSummary = generateSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaReasoning" /> class.
        /// </summary>
        public BetaReasoning()
        {
        }

    }
}