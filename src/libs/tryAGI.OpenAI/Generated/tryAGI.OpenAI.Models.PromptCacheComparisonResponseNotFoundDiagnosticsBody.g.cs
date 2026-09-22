
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptCacheComparisonResponseNotFoundDiagnosticsBody
    {
        /// <summary>
        /// Default Value: comparison_response_not_found
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType Type { get; set; } = global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheComparisonResponseNotFoundDiagnosticsBody" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: comparison_response_not_found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheComparisonResponseNotFoundDiagnosticsBody(
            global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType type = global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheComparisonResponseNotFoundDiagnosticsBody" /> class.
        /// </summary>
        public PromptCacheComparisonResponseNotFoundDiagnosticsBody()
        {
        }

    }
}