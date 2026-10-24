
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionUserInputTextParam
    {
        /// <summary>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionUserInputTextParamType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionUserInputTextParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionUserInputTextParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionUserInputTextParamType.InputText;

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
        /// Initializes a new instance of the <see cref="LiveDecisionUserInputTextParam" /> class.
        /// </summary>
        /// <param name="text">
        /// The text input to the model.
        /// </param>
        /// <param name="type">
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionUserInputTextParam(
            string text,
            global::tryAGI.OpenAI.LiveDecisionUserInputTextParamType type = global::tryAGI.OpenAI.LiveDecisionUserInputTextParamType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionUserInputTextParam" /> class.
        /// </summary>
        public LiveDecisionUserInputTextParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionUserInputTextParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionUserInputTextParam FromText(string text)
        {
            return new LiveDecisionUserInputTextParam
            {
                Text = text,
            };
        }

    }
}