
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text output from the model.
    /// </summary>
    public sealed partial class OutputTextContent
    {
        /// <summary>
        /// The type of the output text. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.OutputTextContentType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.OutputTextContentType Type { get; set; } = global::tryAGI.OpenAI.OutputTextContentType.OutputText;

        /// <summary>
        /// The text output from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The annotations of the text output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation> Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the output text. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </param>
        /// <param name="text">
        /// The text output from the model.
        /// </param>
        /// <param name="annotations">
        /// The annotations of the text output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTextContent(
            string text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation> annotations,
            global::tryAGI.OpenAI.OutputTextContentType type = global::tryAGI.OpenAI.OutputTextContentType.OutputText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextContent" /> class.
        /// </summary>
        public OutputTextContent()
        {
        }
    }
}