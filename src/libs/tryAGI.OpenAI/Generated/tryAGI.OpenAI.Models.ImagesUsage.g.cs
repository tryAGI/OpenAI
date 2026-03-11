
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For the GPT image models only, the token usage information for the image generation.
    /// </summary>
    public sealed partial class ImagesUsage
    {
        /// <summary>
        /// The total number of tokens (images and text) used for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// The number of tokens (images and text) in the input prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// The number of image tokens in the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// The input tokens detailed information for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ImagesUsageInputTokensDetails InputTokensDetails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The total number of tokens (images and text) used for the image generation.
        /// </param>
        /// <param name="inputTokens">
        /// The number of tokens (images and text) in the input prompt.
        /// </param>
        /// <param name="outputTokens">
        /// The number of image tokens in the output image.
        /// </param>
        /// <param name="inputTokensDetails">
        /// The input tokens detailed information for the image generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesUsage(
            int totalTokens,
            int inputTokens,
            int outputTokens,
            global::tryAGI.OpenAI.ImagesUsageInputTokensDetails inputTokensDetails)
        {
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesUsage" /> class.
        /// </summary>
        public ImagesUsage()
        {
        }
    }
}