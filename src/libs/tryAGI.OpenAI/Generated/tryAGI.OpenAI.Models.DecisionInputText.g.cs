
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionInputText
    {
        /// <summary>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputTextType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputTextType Type { get; set; } = global::tryAGI.OpenAI.DecisionInputTextType.InputText;

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="DecisionInputText" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputText(
            string text,
            global::tryAGI.OpenAI.DecisionInputTextType type = global::tryAGI.OpenAI.DecisionInputTextType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputText" /> class.
        /// </summary>
        public DecisionInputText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DecisionInputText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DecisionInputText FromText(string text)
        {
            return new DecisionInputText
            {
                Text = text,
            };
        }

    }
}