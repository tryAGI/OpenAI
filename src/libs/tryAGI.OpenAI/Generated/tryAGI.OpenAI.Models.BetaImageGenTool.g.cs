
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that generates images using the GPT image models.
    /// </summary>
    public sealed partial class BetaImageGenTool
    {
        /// <summary>
        /// The type of the image generation tool. Always `image_generation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaImageGenToolType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>? Model { get; set; }

        /// <summary>
        /// The quality of the generated image. One of `low`, `medium`, `high`,<br/>
        /// or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolQualityJsonConverter))]
        public global::tryAGI.OpenAI.BetaImageGenToolQuality? Quality { get; set; }

        /// <summary>
        /// The size of the generated images. For `gpt-image-2` and `gpt-image-2-2026-04-21`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing. For `dall-e-2`, use one of `256x256`, `512x512`, or `1024x1024`. For `dall-e-3`, use one of `1024x1024`, `1792x1024`, or `1024x1792`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>? Size { get; set; }

        /// <summary>
        /// The output format of the generated image. One of `png`, `webp`, or<br/>
        /// `jpeg`. Default: `png`.<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolOutputFormatJsonConverter))]
        public global::tryAGI.OpenAI.BetaImageGenToolOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Compression level for the output image. Default: 100.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// Moderation level for the generated image. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModerationJsonConverter))]
        public global::tryAGI.OpenAI.BetaImageGenToolModeration? Moderation { get; set; }

        /// <summary>
        /// Background type for the generated image. One of `transparent`,<br/>
        /// `opaque`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolBackgroundJsonConverter))]
        public global::tryAGI.OpenAI.BetaImageGenToolBackground? Background { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_fidelity")]
        public global::tryAGI.OpenAI.BetaInputFidelity? InputFidelity { get; set; }

        /// <summary>
        /// Optional mask for inpainting. Contains `image_url`<br/>
        /// (string, optional) and `file_id` (string, optional).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_mask")]
        public global::tryAGI.OpenAI.BetaImageGenToolInputImageMask? InputImageMask { get; set; }

        /// <summary>
        /// Number of partial images to generate in streaming mode, from 0 (default value) to 3.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_images")]
        public int? PartialImages { get; set; }

        /// <summary>
        /// Whether to generate a new image or edit an existing image. Default: `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageGenActionEnumJsonConverter))]
        public global::tryAGI.OpenAI.BetaImageGenActionEnum? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaImageGenTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the image generation tool. Always `image_generation`.
        /// </param>
        /// <param name="model"></param>
        /// <param name="quality">
        /// The quality of the generated image. One of `low`, `medium`, `high`,<br/>
        /// or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="size">
        /// The size of the generated images. For `gpt-image-2` and `gpt-image-2-2026-04-21`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing. For `dall-e-2`, use one of `256x256`, `512x512`, or `1024x1024`. For `dall-e-3`, use one of `1024x1024`, `1792x1024`, or `1024x1792`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="outputFormat">
        /// The output format of the generated image. One of `png`, `webp`, or<br/>
        /// `jpeg`. Default: `png`.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="outputCompression">
        /// Compression level for the output image. Default: 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="moderation">
        /// Moderation level for the generated image. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="background">
        /// Background type for the generated image. One of `transparent`,<br/>
        /// `opaque`, or `auto`. Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="inputFidelity"></param>
        /// <param name="inputImageMask">
        /// Optional mask for inpainting. Contains `image_url`<br/>
        /// (string, optional) and `file_id` (string, optional).
        /// </param>
        /// <param name="partialImages">
        /// Number of partial images to generate in streaming mode, from 0 (default value) to 3.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="action">
        /// Whether to generate a new image or edit an existing image. Default: `auto`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaImageGenTool(
            global::tryAGI.OpenAI.BetaImageGenToolType type,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>? model,
            global::tryAGI.OpenAI.BetaImageGenToolQuality? quality,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>? size,
            global::tryAGI.OpenAI.BetaImageGenToolOutputFormat? outputFormat,
            int? outputCompression,
            global::tryAGI.OpenAI.BetaImageGenToolModeration? moderation,
            global::tryAGI.OpenAI.BetaImageGenToolBackground? background,
            global::tryAGI.OpenAI.BetaInputFidelity? inputFidelity,
            global::tryAGI.OpenAI.BetaImageGenToolInputImageMask? inputImageMask,
            int? partialImages,
            global::tryAGI.OpenAI.BetaImageGenActionEnum? action)
        {
            this.Type = type;
            this.Model = model;
            this.Quality = quality;
            this.Size = size;
            this.OutputFormat = outputFormat;
            this.OutputCompression = outputCompression;
            this.Moderation = moderation;
            this.Background = background;
            this.InputFidelity = inputFidelity;
            this.InputImageMask = inputImageMask;
            this.PartialImages = partialImages;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaImageGenTool" /> class.
        /// </summary>
        public BetaImageGenTool()
        {
        }

    }
}