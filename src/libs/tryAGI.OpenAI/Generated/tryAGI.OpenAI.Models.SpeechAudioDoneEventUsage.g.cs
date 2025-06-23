
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Token usage statistics for the request.
    /// </summary>
    public sealed partial class SpeechAudioDoneEventUsage
    {
        /// <summary>
        /// Number of input tokens in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

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
        /// Initializes a new instance of the <see cref="SpeechAudioDoneEventUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Number of input tokens in the prompt.
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
        public SpeechAudioDoneEventUsage(
            int inputTokens,
            int outputTokens,
            int totalTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAudioDoneEventUsage" /> class.
        /// </summary>
        public SpeechAudioDoneEventUsage()
        {
        }
    }
}