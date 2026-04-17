
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemMessageUserContentItem
    {
        /// <summary>
        /// The content type (`input_text`, `input_audio`, or `input_image`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserContentItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemType? Type { get; set; }

        /// <summary>
        /// The text content (for `input_text`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes (for `input_audio`), these will be parsed as the format specified in the session input audio type configuration. This defaults to PCM 16-bit 24kHz mono if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Base64-encoded image bytes (for `input_image`) as a data URI. For example `data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAA...`. Supported formats are PNG and JPEG.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The detail level of the image (for `input_image`). `auto` will default to `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeConversationItemMessageUserContentItemDetailJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemDetail? Detail { get; set; }

        /// <summary>
        /// Transcript of the audio (for `input_audio`). This is not sent to the model, but will be attached to the message item for reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemMessageUserContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The content type (`input_text`, `input_audio`, or `input_image`).
        /// </param>
        /// <param name="text">
        /// The text content (for `input_text`).
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio bytes (for `input_audio`), these will be parsed as the format specified in the session input audio type configuration. This defaults to PCM 16-bit 24kHz mono if not specified.
        /// </param>
        /// <param name="imageUrl">
        /// Base64-encoded image bytes (for `input_image`) as a data URI. For example `data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAA...`. Supported formats are PNG and JPEG.
        /// </param>
        /// <param name="detail">
        /// The detail level of the image (for `input_image`). `auto` will default to `high`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="transcript">
        /// Transcript of the audio (for `input_audio`). This is not sent to the model, but will be attached to the message item for reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemMessageUserContentItem(
            global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemType? type,
            string? text,
            string? audio,
            string? imageUrl,
            global::tryAGI.OpenAI.Realtime.RealtimeConversationItemMessageUserContentItemDetail? detail,
            string? transcript)
        {
            this.Type = type;
            this.Text = text;
            this.Audio = audio;
            this.ImageUrl = imageUrl;
            this.Detail = detail;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemMessageUserContentItem" /> class.
        /// </summary>
        public RealtimeConversationItemMessageUserContentItem()
        {
        }
    }
}