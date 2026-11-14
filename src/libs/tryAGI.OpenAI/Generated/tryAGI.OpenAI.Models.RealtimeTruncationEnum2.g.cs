
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Retain a fraction of the conversation tokens when the conversation exceeds the input token limit. This allows you to amortize truncations across multiple turns, which can help improve cached token usage.
    /// </summary>
    public sealed partial class RealtimeTruncationEnum2
    {
        /// <summary>
        /// Use retention ratio truncation.
        /// </summary>
        /// <default>"retention_ratio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "retention_ratio";

        /// <summary>
        /// Fraction of post-instruction conversation tokens to retain (`0.0` - `1.0`) when the conversation exceeds the input token limit. Setting this to `0.8` means that messages will be dropped until 80% of the maximum allowed tokens are used. This helps reduce the frequency of truncations and improve cache rates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RetentionRatio { get; set; }

        /// <summary>
        /// Optional custom token limits for this truncation strategy. If not provided, the model's default token limits will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_limits")]
        public global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits? TokenLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTruncationEnum2" /> class.
        /// </summary>
        /// <param name="retentionRatio">
        /// Fraction of post-instruction conversation tokens to retain (`0.0` - `1.0`) when the conversation exceeds the input token limit. Setting this to `0.8` means that messages will be dropped until 80% of the maximum allowed tokens are used. This helps reduce the frequency of truncations and improve cache rates.
        /// </param>
        /// <param name="tokenLimits">
        /// Optional custom token limits for this truncation strategy. If not provided, the model's default token limits will be used.
        /// </param>
        /// <param name="type">
        /// Use retention ratio truncation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTruncationEnum2(
            double retentionRatio,
            global::tryAGI.OpenAI.RealtimeTruncationEnumTokenLimits? tokenLimits,
            string type = "retention_ratio")
        {
            this.Type = type;
            this.RetentionRatio = retentionRatio;
            this.TokenLimits = tokenLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTruncationEnum2" /> class.
        /// </summary>
        public RealtimeTruncationEnum2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RealtimeTruncationEnum2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RealtimeTruncationEnum2 FromRetentionRatio(double retentionRatio)
        {
            return new RealtimeTruncationEnum2
            {
                RetentionRatio = retentionRatio,
            };
        }

    }
}