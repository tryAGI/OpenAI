
#nullable enable

namespace OpenAI
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectTypeJsonConverter))]
        public global::OpenAI.MessageDeltaContentImageUrlObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::OpenAI.MessageDeltaContentImageUrlObjectImageUrl? ImageUrl { get; set; }

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
        /// <param name="type">
        /// Always `image_url`.
        /// </param>
        /// <param name="imageUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaContentImageUrlObject(
            int index,
            global::OpenAI.MessageDeltaContentImageUrlObjectType type,
            global::OpenAI.MessageDeltaContentImageUrlObjectImageUrl? imageUrl)
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
    }
}