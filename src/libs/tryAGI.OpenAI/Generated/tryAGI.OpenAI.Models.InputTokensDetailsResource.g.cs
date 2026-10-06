
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InputTokensDetailsResource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CachedTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CacheWriteTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokensDetailsResource" /> class.
        /// </summary>
        /// <param name="cachedTokens"></param>
        /// <param name="cacheWriteTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputTokensDetailsResource(
            long cachedTokens,
            long cacheWriteTokens)
        {
            this.CachedTokens = cachedTokens;
            this.CacheWriteTokens = cacheWriteTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokensDetailsResource" /> class.
        /// </summary>
        public InputTokensDetailsResource()
        {
        }

    }
}