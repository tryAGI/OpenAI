
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptCacheHitDiagnosticsBody
    {
        /// <summary>
        /// Default Value: cache_hit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType.CacheHit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheHitDiagnosticsBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType Type { get; set; } = global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType.CacheHit;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheHitDiagnosticsBody" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: cache_hit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheHitDiagnosticsBody(
            global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType type = global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType.CacheHit)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheHitDiagnosticsBody" /> class.
        /// </summary>
        public PromptCacheHitDiagnosticsBody()
        {
        }

    }
}