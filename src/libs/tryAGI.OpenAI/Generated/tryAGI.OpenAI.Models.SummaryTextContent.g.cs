
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A summary text from the model.
    /// </summary>
    public sealed partial class SummaryTextContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Default Value: summary_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SummaryTextContentType.SummaryText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SummaryTextContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.SummaryTextContentType Type { get; set; } = global::tryAGI.OpenAI.SummaryTextContentType.SummaryText;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryTextContent" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Default Value: summary_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryTextContent(
            string text,
            global::tryAGI.OpenAI.SummaryTextContentType type = global::tryAGI.OpenAI.SummaryTextContentType.SummaryText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryTextContent" /> class.
        /// </summary>
        public SummaryTextContent()
        {
        }
    }
}