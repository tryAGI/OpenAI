
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A sample containing the input and output of the evaluation run.
    /// </summary>
    public sealed partial class EvalRunOutputItemSample
    {
        /// <summary>
        /// An object representing an error response from the Eval API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EvalApiError Error { get; set; }

        /// <summary>
        /// The reason why the sample generation was finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FinishReason { get; set; }

        /// <summary>
        /// An array of input messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem> Input { get; set; }

        /// <summary>
        /// The maximum number of tokens allowed for completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCompletionTokens { get; set; }

        /// <summary>
        /// The model used for generating the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// An array of output messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem> Output { get; set; }

        /// <summary>
        /// The seed used for generating the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// The sampling temperature used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// The top_p value used for sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TopP { get; set; }

        /// <summary>
        /// Token usage details for the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EvalRunOutputItemSampleUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSample" /> class.
        /// </summary>
        /// <param name="error">
        /// An object representing an error response from the Eval API.
        /// </param>
        /// <param name="finishReason">
        /// The reason why the sample generation was finished.
        /// </param>
        /// <param name="input">
        /// An array of input messages.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens allowed for completion.
        /// </param>
        /// <param name="model">
        /// The model used for generating the sample.
        /// </param>
        /// <param name="output">
        /// An array of output messages.
        /// </param>
        /// <param name="seed">
        /// The seed used for generating the sample.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature used.
        /// </param>
        /// <param name="topP">
        /// The top_p value used for sampling.
        /// </param>
        /// <param name="usage">
        /// Token usage details for the sample.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunOutputItemSample(
            global::tryAGI.OpenAI.EvalApiError error,
            string finishReason,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleInputItem> input,
            int maxCompletionTokens,
            string model,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalRunOutputItemSampleOutputItem> output,
            int seed,
            double temperature,
            double topP,
            global::tryAGI.OpenAI.EvalRunOutputItemSampleUsage usage)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.FinishReason = finishReason ?? throw new global::System.ArgumentNullException(nameof(finishReason));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.MaxCompletionTokens = maxCompletionTokens;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Seed = seed;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSample" /> class.
        /// </summary>
        public EvalRunOutputItemSample()
        {
        }
    }
}