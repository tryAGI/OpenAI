
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text input recorded in a session item.
    /// </summary>
    public sealed partial class InputContentResourceInputText
    {
        /// <summary>
        /// The type of the object. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.InputContentResourceInputTextType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.InputContentResourceInputTextType Type { get; set; } = global::tryAGI.OpenAI.InputContentResourceInputTextType.InputText;

        /// <summary>
        /// The text supplied to the agent.
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
        /// Initializes a new instance of the <see cref="InputContentResourceInputText" /> class.
        /// </summary>
        /// <param name="text">
        /// The text supplied to the agent.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputContentResourceInputText(
            string text,
            global::tryAGI.OpenAI.InputContentResourceInputTextType type = global::tryAGI.OpenAI.InputContentResourceInputTextType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputContentResourceInputText" /> class.
        /// </summary>
        public InputContentResourceInputText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="InputContentResourceInputText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static InputContentResourceInputText FromText(string text)
        {
            return new InputContentResourceInputText
            {
                Text = text,
            };
        }

    }
}