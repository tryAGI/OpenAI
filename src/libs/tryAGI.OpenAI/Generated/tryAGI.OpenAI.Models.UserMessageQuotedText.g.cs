
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Quoted snippet that the user referenced in their message.
    /// </summary>
    public sealed partial class UserMessageQuotedText
    {
        /// <summary>
        /// Type discriminator that is always `quoted_text`.<br/>
        /// Default Value: quoted_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.UserMessageQuotedTextType.QuotedText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserMessageQuotedTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.UserMessageQuotedTextType Type { get; set; } = global::tryAGI.OpenAI.UserMessageQuotedTextType.QuotedText;

        /// <summary>
        /// Quoted text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageQuotedText" /> class.
        /// </summary>
        /// <param name="type">
        /// Type discriminator that is always `quoted_text`.<br/>
        /// Default Value: quoted_text
        /// </param>
        /// <param name="text">
        /// Quoted text content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessageQuotedText(
            string text,
            global::tryAGI.OpenAI.UserMessageQuotedTextType type = global::tryAGI.OpenAI.UserMessageQuotedTextType.QuotedText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageQuotedText" /> class.
        /// </summary>
        public UserMessageQuotedText()
        {
        }
    }
}