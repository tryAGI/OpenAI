
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For `gpt-image-1` only, the token usage information for the image generation.
    /// </summary>
    public sealed partial class ImagesUsage
    {
        /// <summary>
        /// The number of tokens (images and text) in the input prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The input tokens detailed information for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImagesUsageInputTokensDetails InputTokensDetails { get; set; }

        /// <summary>
        /// The number of image tokens in the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// The total number of tokens (images and text) used for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of tokens (images and text) in the input prompt.
        /// </param>
        /// <param name="inputTokensDetails">
        /// The input tokens detailed information for the image generation.
        /// </param>
        /// <param name="outputTokens">
        /// The number of image tokens in the output image.
        /// </param>
        /// <param name="totalTokens">
        /// The total number of tokens (images and text) used for the image generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesUsage(
            int inputTokens,
            global::tryAGI.OpenAI.ImagesUsageInputTokensDetails inputTokensDetails,
            int outputTokens,
            int totalTokens)
        {
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUsage" /> class.
        /// </summary>
        public ImagesUsage()
        {
        }
    }
}