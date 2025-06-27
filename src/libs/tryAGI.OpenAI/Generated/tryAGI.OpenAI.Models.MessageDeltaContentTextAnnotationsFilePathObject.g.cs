
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
    /// </summary>
    public sealed partial class MessageDeltaContentTextAnnotationsFilePathObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? FilePath { get; set; }

        /// <summary>
        /// The index of the annotation in the text content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Always `file_path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentTextAnnotationsFilePathObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        /// <param name="endIndex"></param>
        /// <param name="filePath"></param>
        /// <param name="index">
        /// The index of the annotation in the text content part.
        /// </param>
        /// <param name="startIndex"></param>
        /// <param name="text">
        /// The text in the message content that needs to be replaced.
        /// </param>
        /// <param name="type">
        /// Always `file_path`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentTextAnnotationsFilePathObject(
            int index,
            int? endIndex,
            global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? filePath,
            int? startIndex,
            string? text,
            global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectType type)
        {
            this.Index = index;
            this.EndIndex = endIndex;
            this.FilePath = filePath;
            this.StartIndex = startIndex;
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        public MessageDeltaContentTextAnnotationsFilePathObject()
        {
        }
    }
}