
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionInputTextParam
    {
        /// <summary>
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionInputTextParamType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionInputTextParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionInputTextParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionInputTextParamType.InputText;

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
        /// Initializes a new instance of the <see cref="LiveDecisionInputTextParam" /> class.
        /// </summary>
        /// <param name="text">
        /// The text input to the model.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionInputTextParam(
            string text,
            global::tryAGI.OpenAI.LiveDecisionInputTextParamType type = global::tryAGI.OpenAI.LiveDecisionInputTextParamType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionInputTextParam" /> class.
        /// </summary>
        public LiveDecisionInputTextParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionInputTextParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionInputTextParam FromText(string text)
        {
            return new LiveDecisionInputTextParam
            {
                Text = text,
            };
        }

    }
}