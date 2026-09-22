
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A breakdown of input token usage for a session or turn.
    /// </summary>
    public sealed partial class InputTokensDetailsResource
    {
        /// <summary>
        /// The number of input tokens retrieved from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokensDetailsResource" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// The number of input tokens retrieved from the prompt cache.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputTokensDetailsResource(
            long cachedTokens)
        {
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTokensDetailsResource" /> class.
        /// </summary>
        public InputTokensDetailsResource()
        {
        }

    }
}