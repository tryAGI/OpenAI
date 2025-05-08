
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text input to the model.
    /// </summary>
    public sealed partial class InputTextContent
    {
        /// <summary>
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputTextContentType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputTextContentType Type { get; set; } = global::tryAGI.OpenAI.InputTextContentType.InputText;

        /// <summary>
        /// The text input to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTextContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
        /// <param name="text">
        /// The text input to the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputTextContent(
            string text,
            global::tryAGI.OpenAI.InputTextContentType type = global::tryAGI.OpenAI.InputTextContentType.InputText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTextContent" /> class.
        /// </summary>
        public InputTextContent()
        {
        }
    }
}