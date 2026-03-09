
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reference an input image by either URL or uploaded file ID.<br/>
    /// Provide exactly one of `image_url` or `file_id`.
    /// </summary>
    public sealed partial class ImageRefParam
    {
        /// <summary>
        /// A fully qualified URL or base64-encoded data URL.<br/>
        /// Example: https://example.com/source-image.png
        /// </summary>
        /// <example>https://example.com/source-image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The File API ID of an uploaded image to use as input.<br/>
        /// Example: file-abc123
        /// </summary>
        /// <example>file-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRefParam" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// A fully qualified URL or base64-encoded data URL.<br/>
        /// Example: https://example.com/source-image.png
        /// </param>
        /// <param name="fileId">
        /// The File API ID of an uploaded image to use as input.<br/>
        /// Example: file-abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageRefParam(
            string? imageUrl,
            string? fileId)
        {
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRefParam" /> class.
        /// </summary>
        public ImageRefParam()
        {
        }
    }
}