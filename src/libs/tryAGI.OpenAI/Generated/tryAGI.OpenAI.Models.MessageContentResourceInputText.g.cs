
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text supplied by the user.
    /// </summary>
    public sealed partial class MessageContentResourceInputText
    {
        /// <summary>
        /// The type of the object. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.MessageContentResourceInputTextType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageContentResourceInputTextType Type { get; set; } = global::tryAGI.OpenAI.MessageContentResourceInputTextType.InputText;

        /// <summary>
        /// The text supplied by the user.
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
        /// Initializes a new instance of the <see cref="MessageContentResourceInputText" /> class.
        /// </summary>
        /// <param name="text">
        /// The text supplied by the user.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentResourceInputText(
            string text,
            global::tryAGI.OpenAI.MessageContentResourceInputTextType type = global::tryAGI.OpenAI.MessageContentResourceInputTextType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentResourceInputText" /> class.
        /// </summary>
        public MessageContentResourceInputText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MessageContentResourceInputText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageContentResourceInputText FromText(string text)
        {
            return new MessageContentResourceInputText
            {
                Text = text,
            };
        }

    }
}