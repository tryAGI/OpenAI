
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text content that is part of a message.
    /// </summary>
    public sealed partial class MessageRequestContentTextObject
    {
        /// <summary>
        /// Text content to be sent to the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageRequestContentTextObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequestContentTextObject" /> class.
        /// </summary>
        /// <param name="text">
        /// Text content to be sent to the model
        /// </param>
        /// <param name="type">
        /// Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageRequestContentTextObject(
            string text,
            global::tryAGI.OpenAI.MessageRequestContentTextObjectType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequestContentTextObject" /> class.
        /// </summary>
        public MessageRequestContentTextObject()
        {
        }
    }
}