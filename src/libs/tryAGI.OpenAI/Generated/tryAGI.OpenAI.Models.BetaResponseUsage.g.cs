
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents token usage details including input tokens, output tokens,<br/>
    /// a breakdown of output tokens, and the total tokens used.
    /// </summary>
    public sealed partial class BetaResponseUsage
    {
        /// <summary>
        /// The number of input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// A detailed breakdown of the input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails InputTokensDetails { get; set; }

        /// <summary>
        /// The number of output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// A detailed breakdown of the output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails OutputTokensDetails { get; set; }

        /// <summary>
        /// The total number of tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens.
        /// </param>
        /// <param name="inputTokensDetails">
        /// A detailed breakdown of the input tokens.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens.
        /// </param>
        /// <param name="outputTokensDetails">
        /// A detailed breakdown of the output tokens.
        /// </param>
        /// <param name="totalTokens">
        /// The total number of tokens used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseUsage(
            int inputTokens,
            global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails inputTokensDetails,
            int outputTokens,
            global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails outputTokensDetails,
            int totalTokens)
        {
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(outputTokensDetails));
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseUsage" /> class.
        /// </summary>
        public BetaResponseUsage()
        {
        }

    }
}