
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References an image [File](/docs/api-reference/files) in the content of a message.
    /// </summary>
    public sealed partial class MessageContentImageFileObject
    {
        /// <summary>
        /// Always `image_file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageFileObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageContentImageFileObjectType Type { get; set; }

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
        /// <param name="type">
        /// Always `image_file`.
        /// </param>
        /// <param name="imageFile"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageContentImageFileObject(
            global::tryAGI.OpenAI.MessageContentImageFileObjectImageFile imageFile,
            global::tryAGI.OpenAI.MessageContentImageFileObjectType type)
        {
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageFileObject" /> class.
        /// </summary>
        public MessageContentImageFileObject()
        {
        }
    }
}