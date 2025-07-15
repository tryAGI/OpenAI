
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text output from the model.
    /// </summary>
    public sealed partial class EvalItemContentVariant3
    {
        /// <summary>
        /// The text output from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the output text. Always `output_text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalItemContentVariant3TypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalItemContentVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemContentVariant3" /> class.
        /// </summary>
        /// <param name="text">
        /// The text output from the model.
        /// </param>
        /// <param name="type">
        /// The type of the output text. Always `output_text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalItemContentVariant3(
            string text,
            global::tryAGI.OpenAI.EvalItemContentVariant3Type type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemContentVariant3" /> class.
        /// </summary>
        public EvalItemContentVariant3()
        {
        }
    }
}