
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Upload permissions and limits applied to the session.
    /// </summary>
    public sealed partial class ChatSessionFileUpload
    {
        /// <summary>
        /// Indicates if uploads are enabled for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_file_size")]
        public int? MaxFileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files")]
        public int? MaxFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionFileUpload" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates if uploads are enabled for the session.
        /// </param>
        /// <param name="maxFileSize"></param>
        /// <param name="maxFiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSessionFileUpload(
            bool enabled,
            int? maxFileSize,
            int? maxFiles)
        {
            this.Enabled = enabled;
            this.MaxFileSize = maxFileSize;
            this.MaxFiles = maxFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionFileUpload" /> class.
        /// </summary>
        public ChatSessionFileUpload()
        {
        }
    }
}