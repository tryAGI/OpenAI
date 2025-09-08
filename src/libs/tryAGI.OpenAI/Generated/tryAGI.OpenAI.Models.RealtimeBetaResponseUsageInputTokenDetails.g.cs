
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about the input tokens used in the Response.
    /// </summary>
    public sealed partial class RealtimeBetaResponseUsageInputTokenDetails
    {
        /// <summary>
        /// The number of audio tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// The number of cached tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Details about the cached tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens_details")]
        public global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails? CachedTokensDetails { get; set; }

        /// <summary>
        /// The number of image tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        /// The number of text tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseUsageInputTokenDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// The number of audio tokens used as input for the Response.
        /// </param>
        /// <param name="cachedTokens">
        /// The number of cached tokens used as input for the Response.
        /// </param>
        /// <param name="cachedTokensDetails">
        /// Details about the cached tokens used as input for the Response.
        /// </param>
        /// <param name="imageTokens">
        /// The number of image tokens used as input for the Response.
        /// </param>
        /// <param name="textTokens">
        /// The number of text tokens used as input for the Response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaResponseUsageInputTokenDetails(
            int? audioTokens,
            int? cachedTokens,
            global::tryAGI.OpenAI.RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails? cachedTokensDetails,
            int? imageTokens,
            int? textTokens)
        {
            this.AudioTokens = audioTokens;
            this.CachedTokens = cachedTokens;
            this.CachedTokensDetails = cachedTokensDetails;
            this.ImageTokens = imageTokens;
            this.TextTokens = textTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseUsageInputTokenDetails" /> class.
        /// </summary>
        public RealtimeBetaResponseUsageInputTokenDetails()
        {
        }
    }
}