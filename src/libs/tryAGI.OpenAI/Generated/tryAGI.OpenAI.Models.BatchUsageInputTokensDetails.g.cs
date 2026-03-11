
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A detailed breakdown of the input tokens.
    /// </summary>
    public sealed partial class BatchUsageInputTokensDetails
    {
        /// <summary>
        /// The number of tokens that were retrieved from the cache. [More on<br/>
        /// prompt caching](/docs/guides/prompt-caching).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CachedTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUsageInputTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// The number of tokens that were retrieved from the cache. [More on<br/>
        /// prompt caching](/docs/guides/prompt-caching).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchUsageInputTokensDetails(
            int cachedTokens)
        {
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUsageInputTokensDetails" /> class.
        /// </summary>
        public BatchUsageInputTokensDetails()
        {
        }
    }
}