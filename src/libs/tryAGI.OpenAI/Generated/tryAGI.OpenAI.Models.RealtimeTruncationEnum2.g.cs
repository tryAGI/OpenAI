
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Retain a fraction of the conversation tokens.
    /// </summary>
    public sealed partial class RealtimeTruncationEnum2
    {
        /// <summary>
        /// Optional cap on tokens allowed after the instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_instructions_token_limit")]
        public int? PostInstructionsTokenLimit { get; set; }

        /// <summary>
        /// Fraction of pre-instruction conversation tokens to retain (0.0 - 1.0).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RetentionRatio { get; set; }

        /// <summary>
        /// Use retention ratio truncation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationEnumTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTruncationEnumType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTruncationEnum2" /> class.
        /// </summary>
        /// <param name="postInstructionsTokenLimit">
        /// Optional cap on tokens allowed after the instructions.
        /// </param>
        /// <param name="retentionRatio">
        /// Fraction of pre-instruction conversation tokens to retain (0.0 - 1.0).
        /// </param>
        /// <param name="type">
        /// Use retention ratio truncation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTruncationEnum2(
            double retentionRatio,
            int? postInstructionsTokenLimit,
            global::tryAGI.OpenAI.RealtimeTruncationEnumType type)
        {
            this.RetentionRatio = retentionRatio;
            this.PostInstructionsTokenLimit = postInstructionsTokenLimit;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTruncationEnum2" /> class.
        /// </summary>
        public RealtimeTruncationEnum2()
        {
        }
    }
}