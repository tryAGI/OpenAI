
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCachedUsageDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_image_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedImageTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCachedUsageDetails" /> class.
        /// </summary>
        /// <param name="cachedTextTokens"></param>
        /// <param name="cachedImageTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCachedUsageDetails(
            int cachedTextTokens,
            int cachedImageTokens)
        {
            this.CachedTextTokens = cachedTextTokens;
            this.CachedImageTokens = cachedImageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCachedUsageDetails" /> class.
        /// </summary>
        public BetaCachedUsageDetails()
        {
        }

    }
}