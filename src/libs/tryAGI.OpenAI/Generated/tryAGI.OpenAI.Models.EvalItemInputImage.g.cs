
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image input block used within EvalItem content arrays.
    /// </summary>
    public sealed partial class EvalItemInputImage
    {
        /// <summary>
        /// The type of the image input. Always `input_image`.
        /// </summary>
        /// <default>"input_image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_image";

        /// <summary>
        /// The URL of the image input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemInputImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The URL of the image input.
        /// </param>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </param>
        /// <param name="type">
        /// The type of the image input. Always `input_image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalItemInputImage(
            string imageUrl,
            string? detail,
            string type = "input_image")
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemInputImage" /> class.
        /// </summary>
        public EvalItemInputImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="EvalItemInputImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static EvalItemInputImage FromImageUrl(string imageUrl)
        {
            return new EvalItemInputImage
            {
                ImageUrl = imageUrl,
            };
        }

    }
}