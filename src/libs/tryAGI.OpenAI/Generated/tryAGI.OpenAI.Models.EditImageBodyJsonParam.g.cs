
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// JSON request body for image edits.<br/>
    /// Use `images` (array of `ImageRefParam`) instead of multipart `image` uploads.<br/>
    /// You can reference images via external URLs, data URLs, or uploaded file IDs.<br/>
    /// JSON edits support GPT image models only; DALL-E edits require multipart (`dall-e-2` only).
    /// </summary>
    public sealed partial class EditImageBodyJsonParam
    {
        /// <summary>
        /// The GPT image model to use for image editing, including `gpt-image-2`, its dated snapshot `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`.<br/>
        /// Default Value: gpt-image-1.5<br/>
        /// Example: gpt-image-1.5
        /// </summary>
        /// <example>gpt-image-1.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>? Model { get; set; }

        /// <summary>
        /// Input image references to edit.<br/>
        /// For GPT image models, you can provide up to 16 images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam> Images { get; set; }

        /// <summary>
        /// Reference an input image by either URL or uploaded file ID.<br/>
        /// Provide exactly one of `image_url` or `file_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public global::tryAGI.OpenAI.ImageRefParam? Mask { get; set; }

        /// <summary>
        /// A text description of the desired image edit.<br/>
        /// Example: Add a watercolor effect and keep the subject centered
        /// </summary>
        /// <example>Add a watercolor effect and keep the subject centered</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The number of edited images to generate.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Output quality for GPT image models. The GPT image models support `low`, `medium`,<br/>
        /// and `high`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their<br/>
        /// `2026-09-08` snapshots, also support `xhigh` and `max`. Defaults to `auto`.<br/>
        /// Default Value: auto<br/>
        /// Example: high
        /// </summary>
        /// <example>high</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public global::tryAGI.OpenAI.EditImageBodyJsonParamQuality? Quality { get; set; }

        /// <summary>
        /// Controls fidelity to the original input image(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_fidelity")]
        public global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity? InputFidelity { get; set; }

        /// <summary>
        /// The size of the generated images. For `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing.<br/>
        /// Default Value: auto<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?, object>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?, object>? Size { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI<br/>
        /// monitor and detect abuse.<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Output image format. Supported for GPT image models.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </summary>
        /// <example>png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Compression level for `jpeg` or `webp` output.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// Moderation level for GPT image models.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public global::tryAGI.OpenAI.EditImageBodyJsonParamModeration? Moderation { get; set; }

        /// <summary>
        /// Set the background of the generated image output. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08` snapshots, support `opaque` and `transparent` backgrounds. Transparent backgrounds are available for supported GPT Image models. For `gpt-image-2` and `gpt-image-2-2026-04-21`, this support is in preview. When using `transparent`, set the output format to `png` or `webp`.<br/>
        /// Default Value: auto<br/>
        /// Example: transparent
        /// </summary>
        /// <example>transparent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::tryAGI.OpenAI.EditImageBodyJsonParamBackground? Background { get; set; }

        /// <summary>
        /// Stream partial image results as events.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_images")]
        public int? PartialImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageBodyJsonParam" /> class.
        /// </summary>
        /// <param name="images">
        /// Input image references to edit.<br/>
        /// For GPT image models, you can provide up to 16 images.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired image edit.<br/>
        /// Example: Add a watercolor effect and keep the subject centered
        /// </param>
        /// <param name="model">
        /// The GPT image model to use for image editing, including `gpt-image-2`, its dated snapshot `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`.<br/>
        /// Default Value: gpt-image-1.5<br/>
        /// Example: gpt-image-1.5
        /// </param>
        /// <param name="mask">
        /// Reference an input image by either URL or uploaded file ID.<br/>
        /// Provide exactly one of `image_url` or `file_id`.
        /// </param>
        /// <param name="n">
        /// The number of edited images to generate.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="quality">
        /// Output quality for GPT image models. The GPT image models support `low`, `medium`,<br/>
        /// and `high`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their<br/>
        /// `2026-09-08` snapshots, also support `xhigh` and `max`. Defaults to `auto`.<br/>
        /// Default Value: auto<br/>
        /// Example: high
        /// </param>
        /// <param name="inputFidelity">
        /// Controls fidelity to the original input image(s).
        /// </param>
        /// <param name="size">
        /// The size of the generated images. For `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing.<br/>
        /// Default Value: auto<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI<br/>
        /// monitor and detect abuse.<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="outputFormat">
        /// Output image format. Supported for GPT image models.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </param>
        /// <param name="outputCompression">
        /// Compression level for `jpeg` or `webp` output.<br/>
        /// Example: 100
        /// </param>
        /// <param name="moderation">
        /// Moderation level for GPT image models.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        /// <param name="background">
        /// Set the background of the generated image output. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08` snapshots, support `opaque` and `transparent` backgrounds. Transparent backgrounds are available for supported GPT Image models. For `gpt-image-2` and `gpt-image-2-2026-04-21`, this support is in preview. When using `transparent`, set the output format to `png` or `webp`.<br/>
        /// Default Value: auto<br/>
        /// Example: transparent
        /// </param>
        /// <param name="stream">
        /// Stream partial image results as events.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="partialImages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageBodyJsonParam(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ImageRefParam> images,
            string prompt,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamModel?, object>? model,
            global::tryAGI.OpenAI.ImageRefParam? mask,
            int? n,
            global::tryAGI.OpenAI.EditImageBodyJsonParamQuality? quality,
            global::tryAGI.OpenAI.EditImageBodyJsonParamInputFidelity? inputFidelity,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.EditImageBodyJsonParamSize?, object>? size,
            string? user,
            global::tryAGI.OpenAI.EditImageBodyJsonParamOutputFormat? outputFormat,
            int? outputCompression,
            global::tryAGI.OpenAI.EditImageBodyJsonParamModeration? moderation,
            global::tryAGI.OpenAI.EditImageBodyJsonParamBackground? background,
            bool? stream,
            int? partialImages)
        {
            this.Model = model;
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Mask = mask;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.N = n;
            this.Quality = quality;
            this.InputFidelity = inputFidelity;
            this.Size = size;
            this.User = user;
            this.OutputFormat = outputFormat;
            this.OutputCompression = outputCompression;
            this.Moderation = moderation;
            this.Background = background;
            this.Stream = stream;
            this.PartialImages = partialImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageBodyJsonParam" /> class.
        /// </summary>
        public EditImageBodyJsonParam()
        {
        }

    }
}