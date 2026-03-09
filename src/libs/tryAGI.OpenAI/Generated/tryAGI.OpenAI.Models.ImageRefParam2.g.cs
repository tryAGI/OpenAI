
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageRefParam2
    {
        /// <summary>
        /// A fully qualified URL or base64-encoded data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Example: file-123
        /// </summary>
        /// <example>file-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRefParam2" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// A fully qualified URL or base64-encoded data URL.
        /// </param>
        /// <param name="fileId">
        /// Example: file-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageRefParam2(
            string? imageUrl,
            string? fileId)
        {
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRefParam2" /> class.
        /// </summary>
        public ImageRefParam2()
        {
        }
    }
}