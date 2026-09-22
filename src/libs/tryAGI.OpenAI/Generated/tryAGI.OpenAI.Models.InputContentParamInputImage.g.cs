
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Image input to the model.
    /// </summary>
    public sealed partial class InputContentParamInputImage
    {
        /// <summary>
        /// The type of the object. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputContentParamInputImageType.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputContentParamInputImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputContentParamInputImageType Type { get; set; } = global::tryAGI.OpenAI.InputContentParamInputImageType.InputImage;

        /// <summary>
        /// The URL of the image sent to the model.
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
        /// Initializes a new instance of the <see cref="InputContentParamInputImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The URL of the image sent to the model.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputContentParamInputImage(
            string imageUrl,
            global::tryAGI.OpenAI.InputContentParamInputImageType type = global::tryAGI.OpenAI.InputContentParamInputImageType.InputImage)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputContentParamInputImage" /> class.
        /// </summary>
        public InputContentParamInputImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="InputContentParamInputImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static InputContentParamInputImage FromImageUrl(string imageUrl)
        {
            return new InputContentParamInputImage
            {
                ImageUrl = imageUrl,
            };
        }

    }
}