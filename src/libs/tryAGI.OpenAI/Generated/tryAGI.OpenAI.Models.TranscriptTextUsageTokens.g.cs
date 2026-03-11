
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Usage statistics for models billed by token usage.
    /// </summary>
    public sealed partial class TranscriptTextUsageTokens
    {
        /// <summary>
        /// The type of the usage object. Always `tokens` for this variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TranscriptTextUsageTokensTypeJsonConverter))]
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensType Type { get; set; }

        /// <summary>
        /// Number of input tokens billed for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Details about the input tokens billed for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_token_details")]
        public global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails? InputTokenDetails { get; set; }

        /// <summary>
        /// Number of output tokens generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Total number of tokens used (input + output).
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
        /// Initializes a new instance of the <see cref="TranscriptTextUsageTokens" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the usage object. Always `tokens` for this variant.
        /// </param>
        /// <param name="inputTokens">
        /// Number of input tokens billed for this request.
        /// </param>
        /// <param name="inputTokenDetails">
        /// Details about the input tokens billed for this request.
        /// </param>
        /// <param name="outputTokens">
        /// Number of output tokens generated.
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used (input + output).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTextUsageTokens(
            int inputTokens,
            int outputTokens,
            int totalTokens,
            global::tryAGI.OpenAI.TranscriptTextUsageTokensType type,
            global::tryAGI.OpenAI.TranscriptTextUsageTokensInputTokenDetails? inputTokenDetails)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.Type = type;
            this.InputTokenDetails = inputTokenDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextUsageTokens" /> class.
        /// </summary>
        public TranscriptTextUsageTokens()
        {
        }
    }
}