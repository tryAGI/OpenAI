
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Details about the input tokens used in the Response. Cached tokens are tokens from previous turns in the conversation that are included as context for the current response. Cached tokens here are counted as a subset of input tokens, meaning input tokens will include cached and uncached tokens.
    /// </summary>
    public sealed partial class RealtimeResponseUsageInputTokenDetails
    {
        /// <summary>
        /// The number of cached tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// The number of text tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// The number of image tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        /// The number of audio tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Details about the cached tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens_details")]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails? CachedTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsageInputTokenDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// The number of cached tokens used as input for the Response.
        /// </param>
        /// <param name="textTokens">
        /// The number of text tokens used as input for the Response.
        /// </param>
        /// <param name="imageTokens">
        /// The number of image tokens used as input for the Response.
        /// </param>
        /// <param name="audioTokens">
        /// The number of audio tokens used as input for the Response.
        /// </param>
        /// <param name="cachedTokensDetails">
        /// Details about the cached tokens used as input for the Response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseUsageInputTokenDetails(
            int? cachedTokens,
            int? textTokens,
            int? imageTokens,
            int? audioTokens,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseUsageInputTokenDetailsCachedTokensDetails? cachedTokensDetails)
        {
            this.CachedTokens = cachedTokens;
            this.TextTokens = textTokens;
            this.ImageTokens = imageTokens;
            this.AudioTokens = audioTokens;
            this.CachedTokensDetails = cachedTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsageInputTokenDetails" /> class.
        /// </summary>
        public RealtimeResponseUsageInputTokenDetails()
        {
        }
    }
}