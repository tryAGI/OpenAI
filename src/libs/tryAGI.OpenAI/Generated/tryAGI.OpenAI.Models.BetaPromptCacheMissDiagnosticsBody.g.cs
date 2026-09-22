
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPromptCacheMissDiagnosticsBody
    {
        /// <summary>
        /// Default Value: cache_miss
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType.CacheMiss</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheMissDiagnosticsBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType Type { get; set; } = global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType.CacheMiss;

        /// <summary>
        /// The reason prompt cache reuse did not occur.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCacheMissReasonTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum Reason { get; set; }

        /// <summary>
        /// The estimated number of input tokens affected after the first detected divergence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_missed_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheMissedTokens { get; set; }

        /// <summary>
        /// The raw token count of the reusable prefix in the compared response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_reusable_tokens")]
        public int? ComparisonReusableTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheMissDiagnosticsBody" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason prompt cache reuse did not occur.
        /// </param>
        /// <param name="cacheMissedTokens">
        /// The estimated number of input tokens affected after the first detected divergence.
        /// </param>
        /// <param name="comparisonReusableTokens">
        /// The raw token count of the reusable prefix in the compared response.
        /// </param>
        /// <param name="type">
        /// Default Value: cache_miss
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPromptCacheMissDiagnosticsBody(
            global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum reason,
            int cacheMissedTokens,
            int? comparisonReusableTokens,
            global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType type = global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType.CacheMiss)
        {
            this.Type = type;
            this.Reason = reason;
            this.CacheMissedTokens = cacheMissedTokens;
            this.ComparisonReusableTokens = comparisonReusableTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheMissDiagnosticsBody" /> class.
        /// </summary>
        public BetaPromptCacheMissDiagnosticsBody()
        {
        }

    }
}