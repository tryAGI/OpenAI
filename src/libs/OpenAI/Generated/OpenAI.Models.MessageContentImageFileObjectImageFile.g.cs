
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentImageFileObjectImageFile
    {
        /// <summary>
        /// The [File](/docs/api-reference/files) ID of the image in the message content. Set `purpose="vision"` when uploading the File if you need to later display the file content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Specifies the detail level of the image if specified by the user. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.MessageContentImageFileObjectImageFileDetailJsonConverter))]
        public global::OpenAI.MessageContentImageFileObjectImageFileDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageFileObjectImageFile" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The [File](/docs/api-reference/files) ID of the image in the message content. Set `purpose="vision"` when uploading the File if you need to later display the file content.
        /// </param>
        /// <param name="detail">
        /// Specifies the detail level of the image if specified by the user. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageContentImageFileObjectImageFile(
            string fileId,
            global::OpenAI.MessageContentImageFileObjectImageFileDetail? detail)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageFileObjectImageFile" /> class.
        /// </summary>
        public MessageContentImageFileObjectImageFile()
        {
        }
    }
}