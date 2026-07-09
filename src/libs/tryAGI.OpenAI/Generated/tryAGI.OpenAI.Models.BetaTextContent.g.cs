
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text content.
    /// </summary>
    public sealed partial class BetaTextContent
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaTextContentType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaTextContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaTextContentType Type { get; set; } = global::tryAGI.OpenAI.BetaTextContentType.Text;

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
        /// Initializes a new instance of the <see cref="BetaTextContent" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTextContent(
            string text,
            global::tryAGI.OpenAI.BetaTextContentType type = global::tryAGI.OpenAI.BetaTextContentType.Text)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTextContent" /> class.
        /// </summary>
        public BetaTextContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaTextContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaTextContent FromText(string text)
        {
            return new BetaTextContent
            {
                Text = text,
            };
        }

    }
}