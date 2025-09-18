
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The sampling parameters for the model.
    /// </summary>
    public sealed partial class GraderScoreModelSamplingParams
    {
        /// <summary>
        /// The maximum number of tokens the grader model may generate in its response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completions_tokens")]
        public int? MaxCompletionsTokens { get; set; }

        /// <summary>
        /// Constrains effort on reasoning for<br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `minimal`, `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningEffortJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// A seed value to initialize the randomness, during sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A higher temperature increases randomness in the outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderScoreModelSamplingParams" /> class.
        /// </summary>
        /// <param name="maxCompletionsTokens">
        /// The maximum number of tokens the grader model may generate in its response.
        /// </param>
        /// <param name="reasoningEffort">
        /// Constrains effort on reasoning for<br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `minimal`, `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="seed">
        /// A seed value to initialize the randomness, during sampling.
        /// </param>
        /// <param name="temperature">
        /// A higher temperature increases randomness in the outputs.
        /// </param>
        /// <param name="topP">
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraderScoreModelSamplingParams(
            int? maxCompletionsTokens,
            global::tryAGI.OpenAI.ReasoningEffort? reasoningEffort,
            int? seed,
            double? temperature,
            double? topP)
        {
            this.MaxCompletionsTokens = maxCompletionsTokens;
            this.ReasoningEffort = reasoningEffort;
            this.Seed = seed;
            this.Temperature = temperature;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderScoreModelSamplingParams" /> class.
        /// </summary>
        public GraderScoreModelSamplingParams()
        {
        }
    }
}