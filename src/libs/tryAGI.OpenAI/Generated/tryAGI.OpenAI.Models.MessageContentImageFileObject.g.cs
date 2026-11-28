
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References an image [File](https://developers.openai.com/api/reference/resources/files) in the content of a message.
    /// </summary>
    public sealed partial class MessageContentImageFileObject
    {
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile ImageFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageFileObject" /> class.
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="type">
        /// Always `image_file`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentImageFileObject(
            global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile imageFile,
            string type = "image_file")
        {
            this.Type = type;
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageFileObject" /> class.
        /// </summary>
        public MessageContentImageFileObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MessageContentImageFileObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MessageContentImageFileObject FromImageFile(global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile imageFile)
        {
            return new MessageContentImageFileObject
            {
                ImageFile = imageFile,
            };
        }

    }
}