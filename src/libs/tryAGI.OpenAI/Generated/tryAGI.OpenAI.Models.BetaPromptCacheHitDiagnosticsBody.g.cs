
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPromptCacheHitDiagnosticsBody
    {
        /// <summary>
        /// Default Value: cache_hit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType.CacheHit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheHitDiagnosticsBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType Type { get; set; } = global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType.CacheHit;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheHitDiagnosticsBody" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: cache_hit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPromptCacheHitDiagnosticsBody(
            global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType type = global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType.CacheHit)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheHitDiagnosticsBody" /> class.
        /// </summary>
        public BetaPromptCacheHitDiagnosticsBody()
        {
        }

    }
}