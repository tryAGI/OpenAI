
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentImageUrlObjectImageUrl
    {
        /// <summary>
        /// The URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter))]
        public global::OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObjectImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </param>
        /// <param name="detail">
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaContentImageUrlObjectImageUrl(
            string? url,
            global::OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? detail)
        {
            this.Url = url;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObjectImageUrl" /> class.
        /// </summary>
        public MessageDeltaContentImageUrlObjectImageUrl()
        {
        }
    }
}