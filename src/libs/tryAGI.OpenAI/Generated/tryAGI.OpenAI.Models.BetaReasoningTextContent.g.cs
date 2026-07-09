
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reasoning text from the model.
    /// </summary>
    public sealed partial class BetaReasoningTextContent
    {
        /// <summary>
        /// The type of the reasoning text. Always `reasoning_text`.<br/>
        /// Default Value: reasoning_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaReasoningTextContentType.ReasoningText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaReasoningTextContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaReasoningTextContentType Type { get; set; } = global::tryAGI.OpenAI.BetaReasoningTextContentType.ReasoningText;

        /// <summary>
        /// The reasoning text from the model.
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
        /// Initializes a new instance of the <see cref="BetaReasoningTextContent" /> class.
        /// </summary>
        /// <param name="text">
        /// The reasoning text from the model.
        /// </param>
        /// <param name="type">
        /// The type of the reasoning text. Always `reasoning_text`.<br/>
        /// Default Value: reasoning_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaReasoningTextContent(
            string text,
            global::tryAGI.OpenAI.BetaReasoningTextContentType type = global::tryAGI.OpenAI.BetaReasoningTextContentType.ReasoningText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaReasoningTextContent" /> class.
        /// </summary>
        public BetaReasoningTextContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaReasoningTextContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaReasoningTextContent FromText(string text)
        {
            return new BetaReasoningTextContent
            {
                Text = text,
            };
        }

    }
}