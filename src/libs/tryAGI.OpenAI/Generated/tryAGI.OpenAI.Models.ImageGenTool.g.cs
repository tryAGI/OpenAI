
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool that generates images using the GPT image models.
    /// </summary>
    public sealed partial class ImageGenTool
    {
        /// <summary>
        /// The type of the image generation tool. Always `image_generation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolModel?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>? Model { get; set; }

        /// <summary>
        /// Computation spent planning the image, independently of rendering quality.<br/>
        /// Overrides the outer response's `reasoning.effort` for image generation.<br/>
        /// When omitted, inherits a supported outer reasoning effort or uses the<br/>
        /// image model's configured default.<br/>
        /// For SVG output, controls the reference image, not the SVG author's<br/>
        /// reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complexity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolComplexityJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolComplexity? Complexity { get; set; }

        /// <summary>
        /// The quality of the generated image. The GPT image models support `low`,<br/>
        /// `medium`, and `high`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`,<br/>
        /// including their `2026-09-08` snapshots, also support `xhigh` and `max`.<br/>
        /// Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolQualityJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolQuality? Quality { get; set; }

        /// <summary>
        /// The size of the generated images. For `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolSize?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>? Size { get; set; }

        /// <summary>
        /// The output format of the generated image. One of `png`, `webp`, `jpeg`,<br/>
        /// `gif`, or `svg`. Default: `png`. GIF and SVG output require a model<br/>
        /// that supports the selected format. GIF output does not support<br/>
        /// partial image streaming (`partial_images` greater than `0`),<br/>
        /// `input_image_mask`, or custom `output_compression`.<br/>
        /// Responses lifecycle events can still be streamed for GIF output.<br/>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolOutputFormatJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Number of GIF frames. Requires `output_format` to be `gif`. Default: 9.<br/>
        /// Default Value: 9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_count")]
        public int? FrameCount { get; set; }

        /// <summary>
        /// Duration of each GIF frame in milliseconds, rounded to 10 ms.<br/>
        /// Requires `output_format` to be `gif`. Default: 200.<br/>
        /// Default Value: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_duration_ms")]
        public int? FrameDurationMs { get; set; }

        /// <summary>
        /// SVG author model settings. Requires `output_format` to be `svg`.<br/>
        /// When SVG model selection is enabled, omitting this object uses the<br/>
        /// outer response model. Otherwise, the default SVG author is used and<br/>
        /// explicit model overrides are unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svg")]
        public global::tryAGI.OpenAI.SvgParam? Svg { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolModerationJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolModeration? Moderation { get; set; }

        /// <summary>
        /// Set the background of the generated image. One of `transparent`, `opaque`,<br/>
        /// or `auto`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including<br/>
        /// their `2026-09-08` snapshots, support `opaque` and `transparent`<br/>
        /// backgrounds. Transparent backgrounds are available for supported GPT Image<br/>
        /// models. For `gpt-image-2` and `gpt-image-2-2026-04-21`, this support is in<br/>
        /// preview. When using `transparent`, set the output format to `png` or `webp`.<br/>
        /// Default: `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolBackgroundJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolBackground? Background { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_fidelity")]
        public global::tryAGI.OpenAI.InputFidelity? InputFidelity { get; set; }

        /// <summary>
        /// Optional mask for inpainting. Contains `image_url`<br/>
        /// (string, optional) and `file_id` (string, optional).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_mask")]
        public global::tryAGI.OpenAI.ImageGenToolInputImageMask? InputImageMask { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenActionEnum? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the image generation tool. Always `image_generation`.
        /// </param>
        /// <param name="model"></param>
        /// <param name="complexity">
        /// Computation spent planning the image, independently of rendering quality.<br/>
        /// Overrides the outer response's `reasoning.effort` for image generation.<br/>
        /// When omitted, inherits a supported outer reasoning effort or uses the<br/>
        /// image model's configured default.<br/>
        /// For SVG output, controls the reference image, not the SVG author's<br/>
        /// reasoning.
        /// </param>
        /// <param name="quality">
        /// The quality of the generated image. The GPT image models support `low`,<br/>
        /// `medium`, and `high`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`,<br/>
        /// including their `2026-09-08` snapshots, also support `xhigh` and `max`.<br/>
        /// Default: `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="size">
        /// The size of the generated images. For `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="outputFormat">
        /// The output format of the generated image. One of `png`, `webp`, `jpeg`,<br/>
        /// `gif`, or `svg`. Default: `png`. GIF and SVG output require a model<br/>
        /// that supports the selected format. GIF output does not support<br/>
        /// partial image streaming (`partial_images` greater than `0`),<br/>
        /// `input_image_mask`, or custom `output_compression`.<br/>
        /// Responses lifecycle events can still be streamed for GIF output.<br/>
        /// Default Value: png
        /// </param>
        /// <param name="frameCount">
        /// Number of GIF frames. Requires `output_format` to be `gif`. Default: 9.<br/>
        /// Default Value: 9
        /// </param>
        /// <param name="frameDurationMs">
        /// Duration of each GIF frame in milliseconds, rounded to 10 ms.<br/>
        /// Requires `output_format` to be `gif`. Default: 200.<br/>
        /// Default Value: 200
        /// </param>
        /// <param name="svg">
        /// SVG author model settings. Requires `output_format` to be `svg`.<br/>
        /// When SVG model selection is enabled, omitting this object uses the<br/>
        /// outer response model. Otherwise, the default SVG author is used and<br/>
        /// explicit model overrides are unavailable.
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
        /// Set the background of the generated image. One of `transparent`, `opaque`,<br/>
        /// or `auto`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including<br/>
        /// their `2026-09-08` snapshots, support `opaque` and `transparent`<br/>
        /// backgrounds. Transparent backgrounds are available for supported GPT Image<br/>
        /// models. For `gpt-image-2` and `gpt-image-2-2026-04-21`, this support is in<br/>
        /// preview. When using `transparent`, set the output format to `png` or `webp`.<br/>
        /// Default: `auto`.<br/>
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
        public ImageGenTool(
            global::tryAGI.OpenAI.ImageGenToolType type,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>? model,
            global::tryAGI.OpenAI.ImageGenToolComplexity? complexity,
            global::tryAGI.OpenAI.ImageGenToolQuality? quality,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>? size,
            global::tryAGI.OpenAI.ImageGenToolOutputFormat? outputFormat,
            int? frameCount,
            int? frameDurationMs,
            global::tryAGI.OpenAI.SvgParam? svg,
            int? outputCompression,
            global::tryAGI.OpenAI.ImageGenToolModeration? moderation,
            global::tryAGI.OpenAI.ImageGenToolBackground? background,
            global::tryAGI.OpenAI.InputFidelity? inputFidelity,
            global::tryAGI.OpenAI.ImageGenToolInputImageMask? inputImageMask,
            int? partialImages,
            global::tryAGI.OpenAI.ImageGenActionEnum? action)
        {
            this.Type = type;
            this.Model = model;
            this.Complexity = complexity;
            this.Quality = quality;
            this.Size = size;
            this.OutputFormat = outputFormat;
            this.FrameCount = frameCount;
            this.FrameDurationMs = frameDurationMs;
            this.Svg = svg;
            this.OutputCompression = outputCompression;
            this.Moderation = moderation;
            this.Background = background;
            this.InputFidelity = inputFidelity;
            this.InputImageMask = inputImageMask;
            this.PartialImages = partialImages;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenTool" /> class.
        /// </summary>
        public ImageGenTool()
        {
        }

    }
}