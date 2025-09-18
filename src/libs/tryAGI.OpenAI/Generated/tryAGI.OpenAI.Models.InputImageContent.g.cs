
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image input to the model. Learn about [image inputs](https://platform.openai.com/docs/guides/vision).
    /// </summary>
    public sealed partial class InputImageContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageDetail Detail { get; set; }

        /// <summary>
        /// The ID of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The URL of the image to be sent to the model. A fully qualified URL or base64 encoded image in a data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputImageContentType.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputImageContentType Type { get; set; } = global::tryAGI.OpenAI.InputImageContentType.InputImage;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContent" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="fileId">
        /// The ID of the file to be sent to the model.
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the image to be sent to the model. A fully qualified URL or base64 encoded image in a data URL.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputImageContent(
            global::tryAGI.OpenAI.ImageDetail detail,
            string? fileId,
            string? imageUrl,
            global::tryAGI.OpenAI.InputImageContentType type = global::tryAGI.OpenAI.InputImageContentType.InputImage)
        {
            this.Detail = detail;
            this.FileId = fileId;
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContent" /> class.
        /// </summary>
        public InputImageContent()
        {
        }
    }
}