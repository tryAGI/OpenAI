
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// References an image [File](/docs/api-reference/files) in the content of a message.
    /// </summary>
    public sealed partial class MessageDeltaContentImageFileObject
    {
        /// <summary>
        /// The index of the content part in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Always `image_file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter))]
        public global::OpenAI.MessageDeltaContentImageFileObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        public global::OpenAI.MessageDeltaContentImageFileObjectImageFile? ImageFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageFileObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the content part in the message.
        /// </param>
        /// <param name="type">
        /// Always `image_file`.
        /// </param>
        /// <param name="imageFile"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaContentImageFileObject(
            int index,
            global::OpenAI.MessageDeltaContentImageFileObjectType type,
            global::OpenAI.MessageDeltaContentImageFileObjectImageFile? imageFile)
        {
            this.Index = index;
            this.Type = type;
            this.ImageFile = imageFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageFileObject" /> class.
        /// </summary>
        public MessageDeltaContentImageFileObject()
        {
        }
    }
}