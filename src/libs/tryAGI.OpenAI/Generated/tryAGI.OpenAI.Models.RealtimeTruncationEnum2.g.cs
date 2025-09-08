
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Retain a fraction of the conversation tokens when the conversation exceeds the input token limit. This allows you to amortize truncations across multiple turns, which can help improve cached token usage.
    /// </summary>
    public sealed partial class RealtimeTruncationEnum2
    {
        /// <summary>
        /// Fraction of post-instruction conversation tokens to retain (0.0 - 1.0) when the conversation exceeds the input token limit.
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
        /// <param name="retentionRatio">
        /// Fraction of post-instruction conversation tokens to retain (0.0 - 1.0) when the conversation exceeds the input token limit.
        /// </param>
        /// <param name="type">
        /// Use retention ratio truncation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTruncationEnum2(
            double retentionRatio,
            global::tryAGI.OpenAI.RealtimeTruncationEnumType type)
        {
            this.RetentionRatio = retentionRatio;
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