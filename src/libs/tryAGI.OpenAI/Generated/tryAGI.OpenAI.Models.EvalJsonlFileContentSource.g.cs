
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalJsonlFileContentSource
    {
        /// <summary>
        /// The content of the jsonl file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem> Content { get; set; }

        /// <summary>
        /// The type of jsonl source. Always `file_content`.<br/>
        /// Default Value: file_content
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalJsonlFileContentSourceType.FileContent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalJsonlFileContentSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalJsonlFileContentSourceType Type { get; set; } = global::tryAGI.OpenAI.EvalJsonlFileContentSourceType.FileContent;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileContentSource" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the jsonl file.
        /// </param>
        /// <param name="type">
        /// The type of jsonl source. Always `file_content`.<br/>
        /// Default Value: file_content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalJsonlFileContentSource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EvalJsonlFileContentSourceContentItem> content,
            global::tryAGI.OpenAI.EvalJsonlFileContentSourceType type = global::tryAGI.OpenAI.EvalJsonlFileContentSourceType.FileContent)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileContentSource" /> class.
        /// </summary>
        public EvalJsonlFileContentSource()
        {
        }
    }
}