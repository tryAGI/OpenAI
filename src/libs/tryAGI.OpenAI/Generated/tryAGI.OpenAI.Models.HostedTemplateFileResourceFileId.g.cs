
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A project-scoped Files API reference resolved separately for each session.
    /// </summary>
    public sealed partial class HostedTemplateFileResourceFileId
    {
        /// <summary>
        /// The type of the object. Always `file_id`.<br/>
        /// Default Value: file_id
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType.FileId</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceFileIdTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType Type { get; set; } = global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType.FileId;

        /// <summary>
        /// The ID of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The file's absolute path inside the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedTemplateFileResourceFileId" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the uploaded file.
        /// </param>
        /// <param name="path">
        /// The file's absolute path inside the environment.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `file_id`.<br/>
        /// Default Value: file_id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedTemplateFileResourceFileId(
            string fileId,
            string path,
            global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType type = global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType.FileId)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedTemplateFileResourceFileId" /> class.
        /// </summary>
        public HostedTemplateFileResourceFileId()
        {
        }

    }
}