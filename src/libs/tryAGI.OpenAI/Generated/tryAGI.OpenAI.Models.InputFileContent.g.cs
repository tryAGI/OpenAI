
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A file input to the model.
    /// </summary>
    public sealed partial class InputFileContent
    {
        /// <summary>
        /// The type of the input item. Always `input_file`.<br/>
        /// Default Value: input_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputFileContentType.InputFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputFileContentType Type { get; set; } = global::tryAGI.OpenAI.InputFileContentType.InputFile;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The name of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The content of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// The URL of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// The detail level of the file to be sent to the model. One of `high` or `low`. Defaults to `high`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FileInputDetailJsonConverter))]
        public global::tryAGI.OpenAI.FileInputDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the input item. Always `input_file`.<br/>
        /// Default Value: input_file
        /// </param>
        /// <param name="fileId"></param>
        /// <param name="filename">
        /// The name of the file to be sent to the model.
        /// </param>
        /// <param name="fileData">
        /// The content of the file to be sent to the model.
        /// </param>
        /// <param name="fileUrl">
        /// The URL of the file to be sent to the model.
        /// </param>
        /// <param name="detail">
        /// The detail level of the file to be sent to the model. One of `high` or `low`. Defaults to `high`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputFileContent(
            string? fileId,
            string? filename,
            string? fileData,
            string? fileUrl,
            global::tryAGI.OpenAI.FileInputDetail? detail,
            global::tryAGI.OpenAI.InputFileContentType type = global::tryAGI.OpenAI.InputFileContentType.InputFile)
        {
            this.Type = type;
            this.FileId = fileId;
            this.Filename = filename;
            this.FileData = fileData;
            this.FileUrl = fileUrl;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileContent" /> class.
        /// </summary>
        public InputFileContent()
        {
        }
    }
}