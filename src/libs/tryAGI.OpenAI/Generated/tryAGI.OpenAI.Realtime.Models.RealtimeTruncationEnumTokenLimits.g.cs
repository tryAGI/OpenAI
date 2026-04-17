
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Optional custom token limits for this truncation strategy. If not provided, the model's default token limits will be used.
    /// </summary>
    public sealed partial class RealtimeTruncationEnumTokenLimits
    {
        /// <summary>
        /// Maximum tokens allowed in the conversation after instructions (which including tool definitions). For example, setting this to 5,000 would mean that truncation would occur when the conversation exceeds 5,000 tokens after instructions. This cannot be higher than the model's context window size minus the maximum output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_instructions")]
        public int? PostInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTruncationEnumTokenLimits" /> class.
        /// </summary>
        /// <param name="postInstructions">
        /// Maximum tokens allowed in the conversation after instructions (which including tool definitions). For example, setting this to 5,000 would mean that truncation would occur when the conversation exceeds 5,000 tokens after instructions. This cannot be higher than the model's context window size minus the maximum output tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTruncationEnumTokenLimits(
            int? postInstructions)
        {
            this.PostInstructions = postInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTruncationEnumTokenLimits" /> class.
        /// </summary>
        public RealtimeTruncationEnumTokenLimits()
        {
        }
    }
}