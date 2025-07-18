
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContainerFileBody
    {
        /// <summary>
        /// The File object (not file name) to be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// The File object (not file name) to be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Name of the file to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerFileBody" /> class.
        /// </summary>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="fileId">
        /// Name of the file to create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContainerFileBody(
            byte[]? file,
            string? filename,
            string? fileId)
        {
            this.File = file;
            this.Filename = filename;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerFileBody" /> class.
        /// </summary>
        public CreateContainerFileBody()
        {
        }
    }
}