
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageRequest
    {
        /// <summary>
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.<br/>
        /// Example: A cute baby sea otter
        /// </summary>
        /// <example>A cute baby sea otter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model to use for image generation.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: dall-e-3
        /// </summary>
        /// <example>dall-e-3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.CreateImageRequestModel?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>? Model { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// The quality of the image that will be generated. `hd` creates images with finer details and greater consistency across the image. This param is only supported for `dall-e-3`.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestQualityJsonConverter))]
        public global::tryAGI.OpenAI.CreateImageRequestQuality? Quality { get; set; }

        /// <summary>
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </summary>
        /// <example>url</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestResponseFormatJsonConverter))]
        public global::tryAGI.OpenAI.CreateImageRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestSizeJsonConverter))]
        public global::tryAGI.OpenAI.CreateImageRequestSize? Size { get; set; }

        /// <summary>
        /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.<br/>
        /// Default Value: vivid<br/>
        /// Example: vivid
        /// </summary>
        /// <example>vivid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateImageRequestStyleJsonConverter))]
        public global::tryAGI.OpenAI.CreateImageRequestStyle? Style { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.<br/>
        /// Example: A cute baby sea otter
        /// </param>
        /// <param name="model">
        /// The model to use for image generation.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: dall-e-3
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated. `hd` creates images with finer details and greater consistency across the image. This param is only supported for `dall-e-3`.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </param>
        /// <param name="responseFormat">
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="style">
        /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.<br/>
        /// Default Value: vivid<br/>
        /// Example: vivid
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageRequest(
            string prompt,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>? model,
            int? n,
            global::tryAGI.OpenAI.CreateImageRequestQuality? quality,
            global::tryAGI.OpenAI.CreateImageRequestResponseFormat? responseFormat,
            global::tryAGI.OpenAI.CreateImageRequestSize? size,
            global::tryAGI.OpenAI.CreateImageRequestStyle? style,
            string? user)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.N = n;
            this.Quality = quality;
            this.ResponseFormat = responseFormat;
            this.Size = size;
            this.Style = style;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        public CreateImageRequest()
        {
        }
    }
}