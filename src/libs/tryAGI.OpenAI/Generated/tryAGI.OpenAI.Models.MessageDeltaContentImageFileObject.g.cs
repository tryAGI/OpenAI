
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References an image [File](/docs/api-reference/files) in the content of a message.
    /// </summary>
    public sealed partial class MessageDeltaContentImageFileObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? ImageFile { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageFileObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageFileObject" /> class.
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="index">
        /// The index of the content part in the message.
        /// </param>
        /// <param name="type">
        /// Always `image_file`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentImageFileObject(
            int index,
            global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectImageFile? imageFile,
            global::tryAGI.OpenAI.MessageDeltaContentImageFileObjectType type)
        {
            this.Index = index;
            this.ImageFile = imageFile;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageFileObject" /> class.
        /// </summary>
        public MessageDeltaContentImageFileObject()
        {
        }
    }
}