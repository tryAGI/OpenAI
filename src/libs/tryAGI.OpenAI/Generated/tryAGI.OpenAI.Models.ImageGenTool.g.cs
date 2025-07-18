
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that generates images using a model like `gpt-image-1`.
    /// </summary>
    public sealed partial class ImageGenTool
    {
        /// <summary>
        /// Background type for the generated image. One of `transparent`, <br/>
        /// `opaque`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolBackgroundJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolBackground? Background { get; set; }

        /// <summary>
        /// Control how much effort the model will exert to match the style and features,<br/>
        /// especially facial features, of input images. This parameter is only supported<br/>
        /// for `gpt-image-1`. Supports `high` and `low`. Defaults to `low`.<br/>
        /// Default Value: low
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_fidelity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageInputFidelityJsonConverter))]
        public global::tryAGI.OpenAI.ImageInputFidelity? InputFidelity { get; set; }

        /// <summary>
        /// Optional mask for inpainting. Contains `image_url` <br/>
        /// (string, optional) and `file_id` (string, optional).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_mask")]
        public global::tryAGI.OpenAI.ImageGenToolInputImageMask? InputImageMask { get; set; }

        /// <summary>
        /// The image generation model to use. Default: `gpt-image-1`.<br/>
        /// Default Value: gpt-image-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolModelJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolModel? Model { get; set; }

        /// <summary>
        /// Moderation level for the generated image. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolModerationJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolModeration? Moderation { get; set; }

        /// <summary>
        /// Compression level for the output image. Default: 100.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// The output format of the generated image. One of `png`, `webp`, or <br/>
        /// `jpeg`. Default: `png`.<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolOutputFormatJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Number of partial images to generate in streaming mode, from 0 (default value) to 3.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_images")]
        public int? PartialImages { get; set; }

        /// <summary>
        /// The quality of the generated image. One of `low`, `medium`, `high`, <br/>
        /// or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolQualityJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolQuality? Quality { get; set; }

        /// <summary>
        /// The size of the generated image. One of `1024x1024`, `1024x1536`, <br/>
        /// `1536x1024`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolSizeJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolSize? Size { get; set; }

        /// <summary>
        /// The type of the image generation tool. Always `image_generation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenTool" /> class.
        /// </summary>
        /// <param name="background">
        /// Background type for the generated image. One of `transparent`, <br/>
        /// `opaque`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="inputFidelity">
        /// Control how much effort the model will exert to match the style and features,<br/>
        /// especially facial features, of input images. This parameter is only supported<br/>
        /// for `gpt-image-1`. Supports `high` and `low`. Defaults to `low`.<br/>
        /// Default Value: low
        /// </param>
        /// <param name="inputImageMask">
        /// Optional mask for inpainting. Contains `image_url` <br/>
        /// (string, optional) and `file_id` (string, optional).
        /// </param>
        /// <param name="model">
        /// The image generation model to use. Default: `gpt-image-1`.<br/>
        /// Default Value: gpt-image-1
        /// </param>
        /// <param name="moderation">
        /// Moderation level for the generated image. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="outputCompression">
        /// Compression level for the output image. Default: 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="outputFormat">
        /// The output format of the generated image. One of `png`, `webp`, or <br/>
        /// `jpeg`. Default: `png`.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="partialImages">
        /// Number of partial images to generate in streaming mode, from 0 (default value) to 3.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="quality">
        /// The quality of the generated image. One of `low`, `medium`, `high`, <br/>
        /// or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="size">
        /// The size of the generated image. One of `1024x1024`, `1024x1536`, <br/>
        /// `1536x1024`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="type">
        /// The type of the image generation tool. Always `image_generation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenTool(
            global::tryAGI.OpenAI.ImageGenToolBackground? background,
            global::tryAGI.OpenAI.ImageInputFidelity? inputFidelity,
            global::tryAGI.OpenAI.ImageGenToolInputImageMask? inputImageMask,
            global::tryAGI.OpenAI.ImageGenToolModel? model,
            global::tryAGI.OpenAI.ImageGenToolModeration? moderation,
            int? outputCompression,
            global::tryAGI.OpenAI.ImageGenToolOutputFormat? outputFormat,
            int? partialImages,
            global::tryAGI.OpenAI.ImageGenToolQuality? quality,
            global::tryAGI.OpenAI.ImageGenToolSize? size,
            global::tryAGI.OpenAI.ImageGenToolType type)
        {
            this.Background = background;
            this.InputFidelity = inputFidelity;
            this.InputImageMask = inputImageMask;
            this.Model = model;
            this.Moderation = moderation;
            this.OutputCompression = outputCompression;
            this.OutputFormat = outputFormat;
            this.PartialImages = partialImages;
            this.Quality = quality;
            this.Size = size;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenTool" /> class.
        /// </summary>
        public ImageGenTool()
        {
        }
    }
}