
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The input tokens detailed information for the image generation.
    /// </summary>
    public sealed partial class ImagesUsageInputTokensDetails
    {
        /// <summary>
        /// The number of image tokens in the input prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ImageTokens { get; set; }

        /// <summary>
        /// The number of text tokens in the input prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TextTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUsageInputTokensDetails" /> class.
        /// </summary>
        /// <param name="imageTokens">
        /// The number of image tokens in the input prompt.
        /// </param>
        /// <param name="textTokens">
        /// The number of text tokens in the input prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesUsageInputTokensDetails(
            int imageTokens,
            int textTokens)
        {
            this.ImageTokens = imageTokens;
            this.TextTokens = textTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUsageInputTokensDetails" /> class.
        /// </summary>
        public ImagesUsageInputTokensDetails()
        {
        }
    }
}