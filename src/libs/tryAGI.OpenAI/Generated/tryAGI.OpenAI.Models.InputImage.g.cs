
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
    /// </summary>
    public sealed partial class InputImage
    {
        /// <summary>
        /// The type of the input item. Always `input_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputImageType Type { get; set; }

        /// <summary>
        /// The URL of the image to be sent to the model. A fully qualified URL or<br/>
        /// base64 encoded image in a data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The ID of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`,<br/>
        /// `low`, or `auto`. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputImageDetail.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InputImageDetail Detail { get; set; } = global::tryAGI.OpenAI.InputImageDetail.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImage" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the input item. Always `input_image`.
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the image to be sent to the model. A fully qualified URL or<br/>
        /// base64 encoded image in a data URL.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to be sent to the model.
        /// </param>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`,<br/>
        /// `low`, or `auto`. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputImage(
            global::tryAGI.OpenAI.InputImageDetail detail,
            global::tryAGI.OpenAI.InputImageType type,
            string? imageUrl,
            string? fileId)
        {
            this.Detail = detail;
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImage" /> class.
        /// </summary>
        public InputImage()
        {
        }
    }
}