
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeResponseInputImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseInputImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImageType Type { get; set; }

        /// <summary>
        /// A base64 data URL with an image MIME type; use PNG or JPEG.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeResponseInputImageDetailJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImageDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// A base64 data URL with an image MIME type; use PNG or JPEG.
        /// </param>
        /// <param name="type"></param>
        /// <param name="detail">
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseInputImage(
            string imageUrl,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImageType type,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputImageDetail? detail)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseInputImage" /> class.
        /// </summary>
        public RealtimeResponseInputImage()
        {
        }

    }
}