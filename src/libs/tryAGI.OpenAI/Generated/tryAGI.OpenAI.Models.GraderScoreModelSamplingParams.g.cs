
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The sampling parameters for the model.
    /// </summary>
    public sealed partial class GraderScoreModelSamplingParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completions_tokens")]
        public int? MaxCompletionsTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public global::tryAGI.OpenAI.ReasoningEffortEnum? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderScoreModelSamplingParams" /> class.
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="topP"></param>
        /// <param name="temperature"></param>
        /// <param name="maxCompletionsTokens"></param>
        /// <param name="reasoningEffort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraderScoreModelSamplingParams(
            int? seed,
            double? topP,
            double? temperature,
            int? maxCompletionsTokens,
            global::tryAGI.OpenAI.ReasoningEffortEnum? reasoningEffort)
        {
            this.Seed = seed;
            this.TopP = topP;
            this.Temperature = temperature;
            this.MaxCompletionsTokens = maxCompletionsTokens;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderScoreModelSamplingParams" /> class.
        /// </summary>
        public GraderScoreModelSamplingParams()
        {
        }
    }
}