
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text content that is part of a message.
    /// </summary>
    public sealed partial class MessageContentTextObject
    {
        /// <summary>
        /// Always `text`.
        /// </summary>
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MessageContentTextObjectText Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObject" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentTextObject(
            global::tryAGI.OpenAI.MessageContentTextObjectText text,
            string type = "text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObject" /> class.
        /// </summary>
        public MessageContentTextObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MessageContentTextObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageContentTextObject FromText(global::tryAGI.OpenAI.MessageContentTextObjectText text)
        {
            return new MessageContentTextObject
            {
                Text = text,
            };
        }

    }
}