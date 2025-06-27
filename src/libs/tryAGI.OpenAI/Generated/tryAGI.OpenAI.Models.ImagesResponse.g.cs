
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The response from the image generation endpoint.
    /// </summary>
    public sealed partial class ImagesResponse
    {
        /// <summary>
        /// The background parameter used for the image generation. Either `transparent` or `opaque`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseBackgroundJsonConverter))]
        public global::tryAGI.OpenAI.ImagesResponseBackground? Background { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the image was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// The list of generated images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Image2>? Data { get; set; }

        /// <summary>
        /// The output format of the image generation. Either `png`, `webp`, or `jpeg`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseOutputFormatJsonConverter))]
        public global::tryAGI.OpenAI.ImagesResponseOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The quality of the image generated. Either `low`, `medium`, or `high`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseQualityJsonConverter))]
        public global::tryAGI.OpenAI.ImagesResponseQuality? Quality { get; set; }

        /// <summary>
        /// The size of the image generated. Either `1024x1024`, `1024x1536`, or `1536x1024`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImagesResponseSizeJsonConverter))]
        public global::tryAGI.OpenAI.ImagesResponseSize? Size { get; set; }

        /// <summary>
        /// For `gpt-image-1` only, the token usage information for the image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::tryAGI.OpenAI.ImagesResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesResponse" /> class.
        /// </summary>
        /// <param name="background">
        /// The background parameter used for the image generation. Either `transparent` or `opaque`.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) of when the image was created.
        /// </param>
        /// <param name="data">
        /// The list of generated images.
        /// </param>
        /// <param name="outputFormat">
        /// The output format of the image generation. Either `png`, `webp`, or `jpeg`.
        /// </param>
        /// <param name="quality">
        /// The quality of the image generated. Either `low`, `medium`, or `high`.
        /// </param>
        /// <param name="size">
        /// The size of the image generated. Either `1024x1024`, `1024x1536`, or `1536x1024`.
        /// </param>
        /// <param name="usage">
        /// For `gpt-image-1` only, the token usage information for the image generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagesResponse(
            global::System.DateTimeOffset created,
            global::tryAGI.OpenAI.ImagesResponseBackground? background,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Image2>? data,
            global::tryAGI.OpenAI.ImagesResponseOutputFormat? outputFormat,
            global::tryAGI.OpenAI.ImagesResponseQuality? quality,
            global::tryAGI.OpenAI.ImagesResponseSize? size,
            global::tryAGI.OpenAI.ImagesResponseUsage? usage)
        {
            this.Created = created;
            this.Background = background;
            this.Data = data;
            this.OutputFormat = outputFormat;
            this.Quality = quality;
            this.Size = size;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesResponse" /> class.
        /// </summary>
        public ImagesResponse()
        {
        }
    }
}