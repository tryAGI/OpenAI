
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when image generation has completed and the final image is available.
    /// </summary>
    public sealed partial class ImageGenCompletedEvent
    {
        /// <summary>
        /// The type of the event. Always `image_generation.completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenCompletedEventType Type { get; set; }

        /// <summary>
        /// Base64-encoded image data, suitable for rendering as an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string B64Json { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The size of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ImageGenCompletedEventSize Size { get; set; } = default!;

        /// <summary>
        /// The quality setting for the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventQualityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ImageGenCompletedEventQuality Quality { get; set; } = default!;

        /// <summary>
        /// The background setting for the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventBackgroundJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ImageGenCompletedEventBackground Background { get; set; } = default!;

        /// <summary>
        /// The output format for the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenCompletedEventOutputFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat OutputFormat { get; set; } = default!;

        /// <summary>
        /// For the GPT image models only, the token usage information for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ImagesUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenCompletedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `image_generation.completed`.
        /// </param>
        /// <param name="b64Json">
        /// Base64-encoded image data, suitable for rendering as an image.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp when the event was created.
        /// </param>
        /// <param name="size">
        /// The size of the generated image.
        /// </param>
        /// <param name="quality">
        /// The quality setting for the generated image.
        /// </param>
        /// <param name="background">
        /// The background setting for the generated image.
        /// </param>
        /// <param name="outputFormat">
        /// The output format for the generated image.
        /// </param>
        /// <param name="usage">
        /// For the GPT image models only, the token usage information for the image generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenCompletedEvent(
            string b64Json,
            global::System.DateTimeOffset createdAt,
            global::tryAGI.OpenAI.ImageGenCompletedEventSize size,
            global::tryAGI.OpenAI.ImageGenCompletedEventQuality quality,
            global::tryAGI.OpenAI.ImageGenCompletedEventBackground background,
            global::tryAGI.OpenAI.ImageGenCompletedEventOutputFormat outputFormat,
            global::tryAGI.OpenAI.ImagesUsage usage,
            global::tryAGI.OpenAI.ImageGenCompletedEventType type)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.CreatedAt = createdAt;
            this.Size = size;
            this.Quality = quality;
            this.Background = background;
            this.OutputFormat = outputFormat;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenCompletedEvent" /> class.
        /// </summary>
        public ImageGenCompletedEvent()
        {
        }
    }
}