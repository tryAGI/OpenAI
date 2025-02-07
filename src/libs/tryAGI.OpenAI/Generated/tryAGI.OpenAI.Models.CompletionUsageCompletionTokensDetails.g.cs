
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Breakdown of tokens used in a completion.
    /// </summary>
    public sealed partial class CompletionUsageCompletionTokensDetails
    {
        /// <summary>
        /// When using Predicted Outputs, the number of tokens in the<br/>
        /// prediction that appeared in the completion.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_prediction_tokens")]
        public int? AcceptedPredictionTokens { get; set; }

        /// <summary>
        /// Audio input tokens generated by the model.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Tokens generated by the model for reasoning.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// When using Predicted Outputs, the number of tokens in the<br/>
        /// prediction that did not appear in the completion. However, like<br/>
        /// reasoning tokens, these tokens are still counted in the total<br/>
        /// completion tokens for purposes of billing, output, and context window<br/>
        /// limits.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected_prediction_tokens")]
        public int? RejectedPredictionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsageCompletionTokensDetails" /> class.
        /// </summary>
        /// <param name="acceptedPredictionTokens">
        /// When using Predicted Outputs, the number of tokens in the<br/>
        /// prediction that appeared in the completion.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="audioTokens">
        /// Audio input tokens generated by the model.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="reasoningTokens">
        /// Tokens generated by the model for reasoning.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="rejectedPredictionTokens">
        /// When using Predicted Outputs, the number of tokens in the<br/>
        /// prediction that did not appear in the completion. However, like<br/>
        /// reasoning tokens, these tokens are still counted in the total<br/>
        /// completion tokens for purposes of billing, output, and context window<br/>
        /// limits.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionUsageCompletionTokensDetails(
            int? acceptedPredictionTokens,
            int? audioTokens,
            int? reasoningTokens,
            int? rejectedPredictionTokens)
        {
            this.AcceptedPredictionTokens = acceptedPredictionTokens;
            this.AudioTokens = audioTokens;
            this.ReasoningTokens = reasoningTokens;
            this.RejectedPredictionTokens = rejectedPredictionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsageCompletionTokensDetails" /> class.
        /// </summary>
        public CompletionUsageCompletionTokensDetails()
        {
        }
    }
}