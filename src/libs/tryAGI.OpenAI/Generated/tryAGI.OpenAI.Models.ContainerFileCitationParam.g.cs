
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContainerFileCitationParam
    {
        /// <summary>
        /// The citation type. Always `container_file_citation`.<br/>
        /// Default Value: container_file_citation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ContainerFileCitationParamType.ContainerFileCitation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ContainerFileCitationParamType Type { get; set; } = global::tryAGI.OpenAI.ContainerFileCitationParamType.ContainerFileCitation;

        /// <summary>
        /// The index of the first character of the citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The index of the last character of the citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// The ID of the container.<br/>
        /// Example: cntr_123
        /// </summary>
        /// <example>cntr_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// The ID of the container file.<br/>
        /// Example: cfile_123
        /// </summary>
        /// <example>cfile_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The filename of the container file cited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileCitationParam" /> class.
        /// </summary>
        /// <param name="startIndex">
        /// The index of the first character of the citation in the message.
        /// </param>
        /// <param name="endIndex">
        /// The index of the last character of the citation in the message.
        /// </param>
        /// <param name="containerId">
        /// The ID of the container.<br/>
        /// Example: cntr_123
        /// </param>
        /// <param name="fileId">
        /// The ID of the container file.<br/>
        /// Example: cfile_123
        /// </param>
        /// <param name="filename">
        /// The filename of the container file cited.
        /// </param>
        /// <param name="type">
        /// The citation type. Always `container_file_citation`.<br/>
        /// Default Value: container_file_citation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerFileCitationParam(
            int startIndex,
            int endIndex,
            string containerId,
            string fileId,
            string filename,
            global::tryAGI.OpenAI.ContainerFileCitationParamType type = global::tryAGI.OpenAI.ContainerFileCitationParamType.ContainerFileCitation)
        {
            this.Type = type;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileCitationParam" /> class.
        /// </summary>
        public ContainerFileCitationParam()
        {
        }

    }
}