
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileSearchToolCallResultsVariant1Item
    {
        /// <summary>
        /// The unique ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The text that was retrieved from the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// The relevance score of the file - a value between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolCallResultsVariant1Item" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The unique ID of the file.
        /// </param>
        /// <param name="text">
        /// The text that was retrieved from the file.
        /// </param>
        /// <param name="filename">
        /// The name of the file.
        /// </param>
        /// <param name="attributes"></param>
        /// <param name="score">
        /// The relevance score of the file - a value between 0 and 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchToolCallResultsVariant1Item(
            string? fileId,
            string? text,
            string? filename,
            object? attributes,
            float? score)
        {
            this.FileId = fileId;
            this.Text = text;
            this.Filename = filename;
            this.Attributes = attributes;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolCallResultsVariant1Item" /> class.
        /// </summary>
        public FileSearchToolCallResultsVariant1Item()
        {
        }
    }
}