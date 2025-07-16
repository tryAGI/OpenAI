
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when image editing has completed and the final image is available.
    /// </summary>
    public sealed partial class ImageEditCompletedEvent
    {
        /// <summary>
        /// Base64-encoded final edited image data, suitable for rendering as an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64Json { get; set; }

        /// <summary>
        /// The background setting for the edited image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventBackgroundJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageEditCompletedEventBackground Background { get; set; }

        /// <summary>
        /// The Unix timestamp when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The output format for the edited image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventOutputFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat OutputFormat { get; set; }

        /// <summary>
        /// The quality setting for the edited image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventQualityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageEditCompletedEventQuality Quality { get; set; }

        /// <summary>
        /// The size of the edited image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageEditCompletedEventSize Size { get; set; }

        /// <summary>
        /// The type of the event. Always `image_edit.completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageEditCompletedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ImageEditCompletedEventType Type { get; set; }

        /// <summary>
        /// For `gpt-image-1` only, the token usage information for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImagesUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEditCompletedEvent" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// Base64-encoded final edited image data, suitable for rendering as an image.
        /// </param>
        /// <param name="background">
        /// The background setting for the edited image.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp when the event was created.
        /// </param>
        /// <param name="outputFormat">
        /// The output format for the edited image.
        /// </param>
        /// <param name="quality">
        /// The quality setting for the edited image.
        /// </param>
        /// <param name="size">
        /// The size of the edited image.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `image_edit.completed`.
        /// </param>
        /// <param name="usage">
        /// For `gpt-image-1` only, the token usage information for the image generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEditCompletedEvent(
            string b64Json,
            global::tryAGI.OpenAI.ImageEditCompletedEventBackground background,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.ImageEditCompletedEventOutputFormat outputFormat,
            global::tryAGI.OpenAI.ImageEditCompletedEventQuality quality,
            global::tryAGI.OpenAI.ImageEditCompletedEventSize size,
            global::tryAGI.OpenAI.ImagesUsage usage,
            global::tryAGI.OpenAI.ImageEditCompletedEventType type)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.Background = background;
            this.CreatedAt = createdAt;
            this.OutputFormat = outputFormat;
            this.Quality = quality;
            this.Size = size;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEditCompletedEvent" /> class.
        /// </summary>
        public ImageEditCompletedEvent()
        {
        }
    }
}