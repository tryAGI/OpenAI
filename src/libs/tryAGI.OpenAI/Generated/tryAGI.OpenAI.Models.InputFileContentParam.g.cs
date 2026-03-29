
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A file input to the model.
    /// </summary>
    public sealed partial class InputFileContentParam
    {
        /// <summary>
        /// The type of the input item. Always `input_file`.<br/>
        /// Default Value: input_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputFileContentParamType.InputFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputFileContentParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputFileContentParamType Type { get; set; } = global::tryAGI.OpenAI.InputFileContentParamType.InputFile;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileContentParam" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="filename"></param>
        /// <param name="fileData"></param>
        /// <param name="fileUrl"></param>
        /// <param name="type">
        /// The type of the input item. Always `input_file`.<br/>
        /// Default Value: input_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputFileContentParam(
            string? fileId,
            string? filename,
            string? fileData,
            string? fileUrl,
            global::tryAGI.OpenAI.InputFileContentParamType type = global::tryAGI.OpenAI.InputFileContentParamType.InputFile)
        {
            this.Type = type;
            this.FileId = fileId;
            this.Filename = filename;
            this.FileData = fileData;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileContentParam" /> class.
        /// </summary>
        public InputFileContentParam()
        {
        }
    }
}