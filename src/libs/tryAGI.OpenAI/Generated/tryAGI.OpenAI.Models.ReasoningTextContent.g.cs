
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reasoning text from the model.
    /// </summary>
    public sealed partial class ReasoningTextContent
    {
        /// <summary>
        /// The reasoning text from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the reasoning text. Always `reasoning_text`.<br/>
        /// Default Value: reasoning_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ReasoningTextContentType.ReasoningText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningTextContentType Type { get; set; } = global::tryAGI.OpenAI.ReasoningTextContentType.ReasoningText;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningTextContent" /> class.
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
        public ReasoningTextContent(
            string text,
            global::tryAGI.OpenAI.ReasoningTextContentType type = global::tryAGI.OpenAI.ReasoningTextContentType.ReasoningText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningTextContent" /> class.
        /// </summary>
        public ReasoningTextContent()
        {
        }
    }
}