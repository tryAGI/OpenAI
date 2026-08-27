
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaFileCitationParam
    {
        /// <summary>
        /// The citation type. Always `file_citation`.<br/>
        /// Default Value: file_citation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaFileCitationParamType.FileCitation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFileCitationParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaFileCitationParamType Type { get; set; } = global::tryAGI.OpenAI.BetaFileCitationParamType.FileCitation;

        /// <summary>
        /// The index of the file in the list of files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The ID of the file.<br/>
        /// Example: file-123
        /// </summary>
        /// <example>file-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaFileCitationParam" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the file in the list of files.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.<br/>
        /// Example: file-123
        /// </param>
        /// <param name="filename">
        /// The filename of the file cited.
        /// </param>
        /// <param name="type">
        /// The citation type. Always `file_citation`.<br/>
        /// Default Value: file_citation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFileCitationParam(
            int index,
            string fileId,
            string filename,
            global::tryAGI.OpenAI.BetaFileCitationParamType type = global::tryAGI.OpenAI.BetaFileCitationParamType.FileCitation)
        {
            this.Type = type;
            this.Index = index;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileCitationParam" /> class.
        /// </summary>
        public BetaFileCitationParam()
        {
        }

    }
}