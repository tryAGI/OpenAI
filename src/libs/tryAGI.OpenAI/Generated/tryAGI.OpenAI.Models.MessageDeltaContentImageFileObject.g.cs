
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References an image [File](https://developers.openai.com/api/reference/resources/files) in the content of a message.
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
        /// <default>"image_file"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image_file";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? ImageFile { get; set; }

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
        /// <param name="imageFile"></param>
        /// <param name="type">
        /// Always `image_file`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentImageFileObject(
            int index,
            global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? imageFile,
            string type = "image_file")
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

        /// <summary>
        /// Creates a new <see cref="MessageDeltaContentImageFileObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageDeltaContentImageFileObject FromIndex(int index)
        {
            return new MessageDeltaContentImageFileObject
            {
                Index = index,
            };
        }

    }
}