
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputImageContent2
    {
        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContent2DetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InputImageContent2Detail Detail { get; set; }

        /// <summary>
        /// The ID of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? FileId { get; set; }

        /// <summary>
        /// The URL of the image to be sent to the model. A fully qualified URL or base64 encoded image in a data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ImageUrl { get; set; }

        /// <summary>
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputImageContent2Type.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContent2TypeJsonConverter))]
        public global::tryAGI.OpenAI.InputImageContent2Type Type { get; set; } = global::tryAGI.OpenAI.InputImageContent2Type.InputImage;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContent2" /> class.
        /// </summary>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </param>
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
        public InputImageContent2(
            global::tryAGI.OpenAI.InputImageContent2Detail detail,
            string? fileId,
            string? imageUrl,
            global::tryAGI.OpenAI.InputImageContent2Type type = global::tryAGI.OpenAI.InputImageContent2Type.InputImage)
        {
            this.Detail = detail;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContent2" /> class.
        /// </summary>
        public InputImageContent2()
        {
        }
    }
}