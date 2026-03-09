
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemInputImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalItemInputImageType Type { get; set; }

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
        /// <param name="type">
        /// The type of the image input. Always `input_image`.
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the image input.
        /// </param>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalItemInputImage(
            string imageUrl,
            global::tryAGI.OpenAI.EvalItemInputImageType type,
            string? detail)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemInputImage" /> class.
        /// </summary>
        public EvalItemInputImage()
        {
        }
    }
}