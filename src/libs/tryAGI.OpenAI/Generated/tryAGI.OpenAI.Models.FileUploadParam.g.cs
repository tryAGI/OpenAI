
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls whether users can upload files.
    /// </summary>
    public sealed partial class FileUploadParam
    {
        /// <summary>
        /// Enable uploads for this session. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum size in megabytes for each uploaded file. Defaults to 512 MB, which is the maximum allowable size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_file_size")]
        public long? MaxFileSize { get; set; }

        /// <summary>
        /// Maximum number of files that can be uploaded to the session. Defaults to 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files")]
        public int? MaxFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadParam" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable uploads for this session. Defaults to false.
        /// </param>
        /// <param name="maxFileSize">
        /// Maximum size in megabytes for each uploaded file. Defaults to 512 MB, which is the maximum allowable size.
        /// </param>
        /// <param name="maxFiles">
        /// Maximum number of files that can be uploaded to the session. Defaults to 10.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileUploadParam(
            bool? enabled,
            long? maxFileSize,
            int? maxFiles)
        {
            this.Enabled = enabled;
            this.MaxFileSize = maxFileSize;
            this.MaxFiles = maxFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadParam" /> class.
        /// </summary>
        public FileUploadParam()
        {
        }
    }
}