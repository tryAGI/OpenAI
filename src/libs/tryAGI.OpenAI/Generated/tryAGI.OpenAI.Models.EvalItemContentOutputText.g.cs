
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text output from the model.
    /// </summary>
    public sealed partial class EvalItemContentOutputText
    {
        /// <summary>
        /// The type of the output text. Always `output_text`.
        /// </summary>
        /// <default>"output_text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "output_text";

        /// <summary>
        /// The text output from the model.
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
        /// Initializes a new instance of the <see cref="EvalItemContentOutputText" /> class.
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
        public EvalItemContentOutputText(
            string text,
            string type = "output_text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemContentOutputText" /> class.
        /// </summary>
        public EvalItemContentOutputText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="EvalItemContentOutputText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static EvalItemContentOutputText FromText(string text)
        {
            return new EvalItemContentOutputText
            {
                Text = text,
            };
        }

    }
}