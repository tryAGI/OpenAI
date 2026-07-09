
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A detailed breakdown of the input tokens.
    /// </summary>
    public sealed partial class BetaResponseUsageInputTokensDetails
    {
        /// <summary>
        /// The number of tokens that were retrieved from the cache. <br/>
        /// [More on prompt caching](/docs/guides/prompt-caching).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTokens { get; set; }

        /// <summary>
        /// The number of input tokens that were written to the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheWriteTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseUsageInputTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// The number of tokens that were retrieved from the cache. <br/>
        /// [More on prompt caching](/docs/guides/prompt-caching).
        /// </param>
        /// <param name="cacheWriteTokens">
        /// The number of input tokens that were written to the cache.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseUsageInputTokensDetails(
            int cachedTokens,
            int cacheWriteTokens)
        {
            this.CachedTokens = cachedTokens;
            this.CacheWriteTokens = cacheWriteTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseUsageInputTokensDetails" /> class.
        /// </summary>
        public BetaResponseUsageInputTokensDetails()
        {
        }

    }
}