
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
    /// </summary>
    public sealed partial class InputImageContent
    {
        /// <summary>
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputImageContentType.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputImageContentType Type { get; set; } = global::tryAGI.OpenAI.InputImageContentType.InputImage;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, object>? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, object>? FileId { get; set; }

        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContentDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InputImageContentDetail Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="fileId"></param>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputImageContent(
            global::tryAGI.OpenAI.InputImageContentDetail detail,
            global::tryAGI.OpenAI.AnyOf<string, object>? imageUrl,
            global::tryAGI.OpenAI.AnyOf<string, object>? fileId,
            global::tryAGI.OpenAI.InputImageContentType type = global::tryAGI.OpenAI.InputImageContentType.InputImage)
        {
            this.Detail = detail;
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContent" /> class.
        /// </summary>
        public InputImageContent()
        {
        }
    }
}