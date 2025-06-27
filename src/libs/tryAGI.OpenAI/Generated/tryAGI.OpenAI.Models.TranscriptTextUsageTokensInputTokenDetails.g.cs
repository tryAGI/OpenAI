
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about the input tokens billed for this request.
    /// </summary>
    public sealed partial class TranscriptTextUsageTokensInputTokenDetails
    {
        /// <summary>
        /// Number of audio tokens billed for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Number of text tokens billed for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextUsageTokensInputTokenDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// Number of audio tokens billed for this request.
        /// </param>
        /// <param name="textTokens">
        /// Number of text tokens billed for this request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTextUsageTokensInputTokenDetails(
            int? audioTokens,
            int? textTokens)
        {
            this.AudioTokens = audioTokens;
            this.TextTokens = textTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextUsageTokensInputTokenDetails" /> class.
        /// </summary>
        public TranscriptTextUsageTokensInputTokenDetails()
        {
        }
    }
}