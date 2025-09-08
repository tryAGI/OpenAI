
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about the cached tokens used as input for the Response.
    /// </summary>
    public sealed partial class RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails
    {
        /// <summary>
        /// The number of cached audio tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// The number of cached image tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        /// The number of cached text tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// The number of cached audio tokens used as input for the Response.
        /// </param>
        /// <param name="imageTokens">
        /// The number of cached image tokens used as input for the Response.
        /// </param>
        /// <param name="textTokens">
        /// The number of cached text tokens used as input for the Response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails(
            int? audioTokens,
            int? imageTokens,
            int? textTokens)
        {
            this.AudioTokens = audioTokens;
            this.ImageTokens = imageTokens;
            this.TextTokens = textTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails" /> class.
        /// </summary>
        public RealtimeBetaResponseUsageInputTokenDetailsCachedTokensDetails()
        {
        }
    }
}