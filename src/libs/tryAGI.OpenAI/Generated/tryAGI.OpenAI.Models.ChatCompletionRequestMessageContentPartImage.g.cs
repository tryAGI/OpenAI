
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Learn about [image inputs](https://platform.openai.com/docs/guides/vision).
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl ImageUrl { get; set; }

        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestMessageContentPartImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartImage(
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl imageUrl,
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartImage()
        {
        }
    }
}