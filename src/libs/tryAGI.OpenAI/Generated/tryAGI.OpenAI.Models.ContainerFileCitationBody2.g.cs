
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerFileCitationBody2
    {
        /// <summary>
        /// The ID of the container file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// The index of the last character of the container file citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// The ID of the file.
        /// </summary>
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
        /// The index of the first character of the container file citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The type of the container file citation. Always `container_file_citation`.<br/>
        /// Default Value: container_file_citation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ContainerFileCitationBody2Type.ContainerFileCitation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBody2TypeJsonConverter))]
        public global::tryAGI.OpenAI.ContainerFileCitationBody2Type Type { get; set; } = global::tryAGI.OpenAI.ContainerFileCitationBody2Type.ContainerFileCitation;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileCitationBody2" /> class.
        /// </summary>
        /// <param name="containerId">
        /// The ID of the container file.
        /// </param>
        /// <param name="endIndex">
        /// The index of the last character of the container file citation in the message.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="filename">
        /// The filename of the container file cited.
        /// </param>
        /// <param name="startIndex">
        /// The index of the first character of the container file citation in the message.
        /// </param>
        /// <param name="type">
        /// The type of the container file citation. Always `container_file_citation`.<br/>
        /// Default Value: container_file_citation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerFileCitationBody2(
            string containerId,
            int endIndex,
            string fileId,
            string filename,
            int startIndex,
            global::tryAGI.OpenAI.ContainerFileCitationBody2Type type = global::tryAGI.OpenAI.ContainerFileCitationBody2Type.ContainerFileCitation)
        {
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.EndIndex = endIndex;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.StartIndex = startIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileCitationBody2" /> class.
        /// </summary>
        public ContainerFileCitationBody2()
        {
        }
    }
}