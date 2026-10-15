
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionInputOutputText
    {
        /// <summary>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputOutputTextType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputOutputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputOutputTextType Type { get; set; } = global::tryAGI.OpenAI.DecisionInputOutputTextType.OutputText;

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
        /// Initializes a new instance of the <see cref="DecisionInputOutputText" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Default Value: output_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputOutputText(
            string text,
            global::tryAGI.OpenAI.DecisionInputOutputTextType type = global::tryAGI.OpenAI.DecisionInputOutputTextType.OutputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputOutputText" /> class.
        /// </summary>
        public DecisionInputOutputText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DecisionInputOutputText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DecisionInputOutputText FromText(string text)
        {
            return new DecisionInputOutputText
            {
                Text = text,
            };
        }

    }
}