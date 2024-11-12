
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The text content that is part of a message.
    /// </summary>
    public sealed partial class MessageRequestContentTextObject
    {
        /// <summary>
        /// Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.MessageRequestContentTextObjectTypeJsonConverter))]
        public global::OpenAI.MessageRequestContentTextObjectType Type { get; set; }

        /// <summary>
        /// Text content to be sent to the model
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
        /// Initializes a new instance of the <see cref="MessageRequestContentTextObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `text`.
        /// </param>
        /// <param name="text">
        /// Text content to be sent to the model
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageRequestContentTextObject(
            string text,
            global::OpenAI.MessageRequestContentTextObjectType type)
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