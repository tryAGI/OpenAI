
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody
    {
        /// <summary>
        /// Default Value: comparison_response_not_found
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType Type { get; set; } = global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: comparison_response_not_found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody(
            global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType type = global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody" /> class.
        /// </summary>
        public BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody()
        {
        }

    }
}