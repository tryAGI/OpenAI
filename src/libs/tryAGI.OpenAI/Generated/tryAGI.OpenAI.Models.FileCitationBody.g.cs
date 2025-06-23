
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A citation to a file.
    /// </summary>
    public sealed partial class FileCitationBody
    {
        /// <summary>
        /// The type of the file citation. Always `file_citation`.<br/>
        /// Default Value: file_citation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FileCitationBodyType.FileCitation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.FileCitationBodyType Type { get; set; } = global::tryAGI.OpenAI.FileCitationBodyType.FileCitation;

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The index of the file in the list of files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The filename of the file cited.
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
        /// Initializes a new instance of the <see cref="FileCitationBody" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the file citation. Always `file_citation`.<br/>
        /// Default Value: file_citation
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="index">
        /// The index of the file in the list of files.
        /// </param>
        /// <param name="filename">
        /// The filename of the file cited.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCitationBody(
            string fileId,
            int index,
            string filename,
            global::tryAGI.OpenAI.FileCitationBodyType type = global::tryAGI.OpenAI.FileCitationBodyType.FileCitation)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Index = index;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitationBody" /> class.
        /// </summary>
        public FileCitationBody()
        {
        }
    }
}