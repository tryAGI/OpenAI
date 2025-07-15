
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image input to the model.
    /// </summary>
    public sealed partial class EvalItemContentVariant4
    {
        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// The URL of the image input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// The type of the image input. Always `input_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemContentVariant4TypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalItemContentVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemContentVariant4" /> class.
        /// </summary>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the image input.
        /// </param>
        /// <param name="type">
        /// The type of the image input. Always `input_image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalItemContentVariant4(
            string imageUrl,
            string? detail,
            global::tryAGI.OpenAI.EvalItemContentVariant4Type type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Detail = detail;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemContentVariant4" /> class.
        /// </summary>
        public EvalItemContentVariant4()
        {
        }
    }
}