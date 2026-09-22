
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Text produced by the assistant.
    /// </summary>
    public sealed partial class MessageContentResourceOutputText
    {
        /// <summary>
        /// The type of the object. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.MessageContentResourceOutputTextType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentResourceOutputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageContentResourceOutputTextType Type { get; set; } = global::tryAGI.OpenAI.MessageContentResourceOutputTextType.OutputText;

        /// <summary>
        /// The text produced by the assistant.
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
        /// Initializes a new instance of the <see cref="MessageContentResourceOutputText" /> class.
        /// </summary>
        /// <param name="text">
        /// The text produced by the assistant.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentResourceOutputText(
            string text,
            global::tryAGI.OpenAI.MessageContentResourceOutputTextType type = global::tryAGI.OpenAI.MessageContentResourceOutputTextType.OutputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentResourceOutputText" /> class.
        /// </summary>
        public MessageContentResourceOutputText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MessageContentResourceOutputText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageContentResourceOutputText FromText(string text)
        {
            return new MessageContentResourceOutputText
            {
                Text = text,
            };
        }

    }
}