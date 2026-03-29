
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image input to the model. Learn about [image inputs](/docs/guides/vision)
    /// </summary>
    public sealed partial class InputImageContentParamAutoParam
    {
        /// <summary>
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputImageContentParamAutoParamType.InputImage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputImageContentParamAutoParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputImageContentParamAutoParamType Type { get; set; } = global::tryAGI.OpenAI.InputImageContentParamAutoParamType.InputImage;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::tryAGI.OpenAI.DetailEnum? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContentParamAutoParam" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="fileId"></param>
        /// <param name="detail"></param>
        /// <param name="type">
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputImageContentParamAutoParam(
            string? imageUrl,
            string? fileId,
            global::tryAGI.OpenAI.DetailEnum? detail,
            global::tryAGI.OpenAI.InputImageContentParamAutoParamType type = global::tryAGI.OpenAI.InputImageContentParamAutoParamType.InputImage)
        {
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContentParamAutoParam" /> class.
        /// </summary>
        public InputImageContentParamAutoParam()
        {
        }
    }
}