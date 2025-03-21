
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A citation to a file.
    /// </summary>
    public sealed partial class FileCitation
    {
        /// <summary>
        /// The type of the file citation. Always `file_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FileCitationTypeJsonConverter))]
        public global::tryAGI.OpenAI.FileCitationType Type { get; set; }

        /// <summary>
        /// The index of the file in the list of files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the file citation. Always `file_citation`.
        /// </param>
        /// <param name="index">
        /// The index of the file in the list of files.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCitation(
            int index,
            string fileId,
            global::tryAGI.OpenAI.FileCitationType type)
        {
            this.Index = index;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitation" /> class.
        /// </summary>
        public FileCitation()
        {
        }
    }
}