
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Assistant response text accompanied by optional annotations.
    /// </summary>
    public sealed partial class ResponseOutputText
    {
        /// <summary>
        /// Type discriminator that is always `output_text`.<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ResponseOutputTextType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseOutputTextType Type { get; set; } = global::tryAGI.OpenAI.ResponseOutputTextType.OutputText;

        /// <summary>
        /// Assistant generated text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Ordered list of annotations attached to the response text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3> Annotations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputText" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator that is always `output_text`.<br/>
        /// Default Value: output_text
        /// </param>
        /// <param name="text">
        /// Assistant generated text.
        /// </param>
        /// <param name="annotations">
        /// Ordered list of annotations attached to the response text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputText(
            string text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem3> annotations,
            global::tryAGI.OpenAI.ResponseOutputTextType type = global::tryAGI.OpenAI.ResponseOutputTextType.OutputText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputText" /> class.
        /// </summary>
        public ResponseOutputText()
        {
        }
    }
}