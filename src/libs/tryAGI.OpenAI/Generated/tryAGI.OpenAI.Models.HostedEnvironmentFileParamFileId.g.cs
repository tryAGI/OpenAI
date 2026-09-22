
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A file previously uploaded through the OpenAI Files API.
    /// </summary>
    public sealed partial class HostedEnvironmentFileParamFileId
    {
        /// <summary>
        /// The type of the object. Always `file_id`.<br/>
        /// Default Value: file_id
        /// </summary>
        /// <default>global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType.FileId</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamFileIdTypeJsonConverter))]
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType Type { get; set; } = global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType.FileId;

        /// <summary>
        /// The ID of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The absolute destination path inside `/workspace`.
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
        /// Initializes a new instance of the <see cref="HostedEnvironmentFileParamFileId" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the uploaded file.
        /// </param>
        /// <param name="path">
        /// The absolute destination path inside `/workspace`.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `file_id`.<br/>
        /// Default Value: file_id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedEnvironmentFileParamFileId(
            string fileId,
            string path,
            global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType type = global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType.FileId)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedEnvironmentFileParamFileId" /> class.
        /// </summary>
        public HostedEnvironmentFileParamFileId()
        {
        }

    }
}