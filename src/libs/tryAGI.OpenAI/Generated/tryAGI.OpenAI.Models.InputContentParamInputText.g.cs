
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text input to the model.
    /// </summary>
    public sealed partial class InputContentParamInputText
    {
        /// <summary>
        /// The type of the object. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputContentParamInputTextType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputContentParamInputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputContentParamInputTextType Type { get; set; } = global::tryAGI.OpenAI.InputContentParamInputTextType.InputText;

        /// <summary>
        /// The text sent to the model.
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
        /// Initializes a new instance of the <see cref="InputContentParamInputText" /> class.
        /// </summary>
        /// <param name="text">
        /// The text sent to the model.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputContentParamInputText(
            string text,
            global::tryAGI.OpenAI.InputContentParamInputTextType type = global::tryAGI.OpenAI.InputContentParamInputTextType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputContentParamInputText" /> class.
        /// </summary>
        public InputContentParamInputText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="InputContentParamInputText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static InputContentParamInputText FromText(string text)
        {
            return new InputContentParamInputText
            {
                Text = text,
            };
        }

    }
}