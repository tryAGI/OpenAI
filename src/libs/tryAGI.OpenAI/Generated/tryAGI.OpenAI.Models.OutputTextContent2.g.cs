
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputTextContent2
    {
        /// <summary>
        /// The annotations of the text output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation2> Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb2>? Logprobs { get; set; }

        /// <summary>
        /// The text output from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the output text. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.OutputTextContent2Type.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputTextContent2TypeJsonConverter))]
        public global::tryAGI.OpenAI.OutputTextContent2Type Type { get; set; } = global::tryAGI.OpenAI.OutputTextContent2Type.OutputText;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextContent2" /> class.
        /// </summary>
        /// <param name="annotations">
        /// The annotations of the text output.
        /// </param>
        /// <param name="logprobs"></param>
        /// <param name="text">
        /// The text output from the model.
        /// </param>
        /// <param name="type">
        /// The type of the output text. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTextContent2(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation2> annotations,
            string text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb2>? logprobs,
            global::tryAGI.OpenAI.OutputTextContent2Type type = global::tryAGI.OpenAI.OutputTextContent2Type.OutputText)
        {
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Logprobs = logprobs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextContent2" /> class.
        /// </summary>
        public OutputTextContent2()
        {
        }
    }
}