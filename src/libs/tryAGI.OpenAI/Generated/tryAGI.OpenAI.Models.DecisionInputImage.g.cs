
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An inline image. External URLs and file IDs are not supported.
    /// </summary>
    public sealed partial class DecisionInputImage
    {
        /// <summary>
        /// A base64-encoded image in a data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// The image detail level, using the selected model's image profile. Defaults to auto.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::tryAGI.OpenAI.ImageDetailParam? Detail { get; set; }

        /// <summary>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputImageType.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputImageType Type { get; set; } = global::tryAGI.OpenAI.DecisionInputImageType.InputImage;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// A base64-encoded image in a data URL.
        /// </param>
        /// <param name="detail">
        /// The image detail level, using the selected model's image profile. Defaults to auto.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="type">
        /// Default Value: input_image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputImage(
            string imageUrl,
            global::tryAGI.OpenAI.ImageDetailParam? detail,
            global::tryAGI.OpenAI.DecisionInputImageType type = global::tryAGI.OpenAI.DecisionInputImageType.InputImage)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Detail = detail;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputImage" /> class.
        /// </summary>
        public DecisionInputImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DecisionInputImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DecisionInputImage FromImageUrl(string imageUrl)
        {
            return new DecisionInputImage
            {
                ImageUrl = imageUrl,
            };
        }

    }
}