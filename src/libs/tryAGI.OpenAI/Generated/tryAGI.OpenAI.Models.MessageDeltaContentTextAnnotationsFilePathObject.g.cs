
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A URL for the file that's generated when the assistant used the `code_interpreter` tool to generate a file.
    /// </summary>
    public sealed partial class MessageDeltaContentTextAnnotationsFilePathObject
    {
        /// <summary>
        /// The index of the annotation in the text content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Always `file_path`.
        /// </summary>
        /// <default>"file_path"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file_path";

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? FilePath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the annotation in the text content part.
        /// </param>
        /// <param name="text">
        /// The text in the message content that needs to be replaced.
        /// </param>
        /// <param name="filePath"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <param name="type">
        /// Always `file_path`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentTextAnnotationsFilePathObject(
            int index,
            string? text,
            global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObjectFilePath? filePath,
            int? startIndex,
            int? endIndex,
            string type = "file_path")
        {
            this.Index = index;
            this.Type = type;
            this.Text = text;
            this.FilePath = filePath;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        public MessageDeltaContentTextAnnotationsFilePathObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MessageDeltaContentTextAnnotationsFilePathObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageDeltaContentTextAnnotationsFilePathObject FromIndex(int index)
        {
            return new MessageDeltaContentTextAnnotationsFilePathObject
            {
                Index = index,
            };
        }

    }
}