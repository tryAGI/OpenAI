
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a partial image is available during image generation streaming.
    /// </summary>
    public sealed partial class ImageGenPartialImageEvent
    {
        /// <summary>
        /// Base64-encoded partial image data, suitable for rendering as an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64Json { get; set; }

        /// <summary>
        /// The background setting for the requested image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventBackgroundJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageGenPartialImageEventBackground Background { get; set; }

        /// <summary>
        /// The Unix timestamp when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The output format for the requested image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventOutputFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat OutputFormat { get; set; }

        /// <summary>
        /// 0-based index for the partial image (streaming).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_image_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartialImageIndex { get; set; }

        /// <summary>
        /// The quality setting for the requested image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventQualityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageGenPartialImageEventQuality Quality { get; set; }

        /// <summary>
        /// The size of the requested image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageGenPartialImageEventSize Size { get; set; }

        /// <summary>
        /// The type of the event. Always `image_generation.partial_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenPartialImageEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenPartialImageEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenPartialImageEvent" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// Base64-encoded partial image data, suitable for rendering as an image.
        /// </param>
        /// <param name="background">
        /// The background setting for the requested image.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp when the event was created.
        /// </param>
        /// <param name="outputFormat">
        /// The output format for the requested image.
        /// </param>
        /// <param name="partialImageIndex">
        /// 0-based index for the partial image (streaming).
        /// </param>
        /// <param name="quality">
        /// The quality setting for the requested image.
        /// </param>
        /// <param name="size">
        /// The size of the requested image.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `image_generation.partial_image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenPartialImageEvent(
            string b64Json,
            global::tryAGI.OpenAI.ImageGenPartialImageEventBackground background,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.ImageGenPartialImageEventOutputFormat outputFormat,
            int partialImageIndex,
            global::tryAGI.OpenAI.ImageGenPartialImageEventQuality quality,
            global::tryAGI.OpenAI.ImageGenPartialImageEventSize size,
            global::tryAGI.OpenAI.ImageGenPartialImageEventType type)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.Background = background;
            this.CreatedAt = createdAt;
            this.OutputFormat = outputFormat;
            this.PartialImageIndex = partialImageIndex;
            this.Quality = quality;
            this.Size = size;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenPartialImageEvent" /> class.
        /// </summary>
        public ImageGenPartialImageEvent()
        {
        }
    }
}