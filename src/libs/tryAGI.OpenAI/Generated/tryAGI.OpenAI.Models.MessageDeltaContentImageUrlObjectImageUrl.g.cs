
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentImageUrlObjectImageUrl
    {
        /// <summary>
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageDeltaContentImageUrlObjectImageUrlDetailJsonConverter))]
        public global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// The URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObjectImageUrl" /> class.
        /// </summary>
        /// <param name="detail">
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="url">
        /// The URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentImageUrlObjectImageUrl(
            global::tryAGI.OpenAI.MessageDeltaContentImageUrlObjectImageUrlDetail? detail,
            string? url)
        {
            this.Detail = detail;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageUrlObjectImageUrl" /> class.
        /// </summary>
        public MessageDeltaContentImageUrlObjectImageUrl()
        {
        }
    }
}