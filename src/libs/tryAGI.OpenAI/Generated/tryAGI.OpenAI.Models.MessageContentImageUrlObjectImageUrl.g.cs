
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentImageUrlObjectImageUrl
    {
        /// <summary>
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`. Default value is `auto`<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentImageUrlObjectImageUrlDetailJsonConverter))]
        public global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// The external URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageUrlObjectImageUrl" /> class.
        /// </summary>
        /// <param name="detail">
        /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`. Default value is `auto`<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="url">
        /// The external URL of the image, must be a supported image types: jpeg, jpg, png, gif, webp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentImageUrlObjectImageUrl(
            string url,
            global::tryAGI.OpenAI.MessageContentImageUrlObjectImageUrlDetail? detail)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageUrlObjectImageUrl" /> class.
        /// </summary>
        public MessageContentImageUrlObjectImageUrl()
        {
        }
    }
}