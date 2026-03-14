
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about the cached tokens used as input for the Response.
    /// </summary>
    public sealed partial class RealtimeResponseUsageInputTokenDetailsCachedTokensDetails
    {
        /// <summary>
        /// The number of cached text tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// The number of cached image tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        /// The number of cached audio tokens used as input for the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsageInputTokenDetailsCachedTokensDetails" /> class.
        /// </summary>
        /// <param name="textTokens">
        /// The number of cached text tokens used as input for the Response.
        /// </param>
        /// <param name="imageTokens">
        /// The number of cached image tokens used as input for the Response.
        /// </param>
        /// <param name="audioTokens">
        /// The number of cached audio tokens used as input for the Response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseUsageInputTokenDetailsCachedTokensDetails(
            int? textTokens,
            int? imageTokens,
            int? audioTokens)
        {
            this.TextTokens = textTokens;
            this.ImageTokens = imageTokens;
            this.AudioTokens = audioTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsageInputTokenDetailsCachedTokensDetails" /> class.
        /// </summary>
        public RealtimeResponseUsageInputTokenDetailsCachedTokensDetails()
        {
        }
    }
}