
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image supplied by the user.
    /// </summary>
    public sealed partial class MessageContentResourceInputImage
    {
        /// <summary>
        /// The type of the object. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.MessageContentResourceInputImageType.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageContentResourceInputImageType Type { get; set; } = global::tryAGI.OpenAI.MessageContentResourceInputImageType.InputImage;

        /// <summary>
        /// The URL of the image supplied by the user, which may be a base64-encoded data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentResourceInputImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The URL of the image supplied by the user, which may be a base64-encoded data URL.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentResourceInputImage(
            string imageUrl,
            global::tryAGI.OpenAI.MessageContentResourceInputImageType type = global::tryAGI.OpenAI.MessageContentResourceInputImageType.InputImage)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentResourceInputImage" /> class.
        /// </summary>
        public MessageContentResourceInputImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MessageContentResourceInputImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageContentResourceInputImage FromImageUrl(string imageUrl)
        {
            return new MessageContentResourceInputImage
            {
                ImageUrl = imageUrl,
            };
        }

    }
}