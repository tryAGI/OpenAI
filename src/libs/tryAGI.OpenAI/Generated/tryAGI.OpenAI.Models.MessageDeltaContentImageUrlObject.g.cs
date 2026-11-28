
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References an image URL in the content of a message.
    /// </summary>
    public sealed partial class MessageDeltaContentImageUrlObject
    {
        /// <summary>
        /// The index of the content part in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Always `image_url`.
        /// </summary>
        /// <default>"image_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image_url";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the content part in the message.
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// Always `image_url`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentImageUrlObject(
            int index,
            global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrl? imageUrl,
            string type = "image_url")
        {
            this.Index = index;
            this.Type = type;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObject" /> class.
        /// </summary>
        public MessageDeltaContentImageUrlObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MessageDeltaContentImageUrlObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageDeltaContentImageUrlObject FromIndex(int index)
        {
            return new MessageDeltaContentImageUrlObject
            {
                Index = index,
            };
        }

    }
}