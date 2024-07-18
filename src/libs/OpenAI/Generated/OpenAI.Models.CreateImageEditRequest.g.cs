
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageEditRequest
    {
        /// <summary>
        /// The image to edit. Must be a valid PNG file, less than 4MB, and square. If mask is not provided, image must have transparency, which will be used as the mask.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// A text description of the desired image(s). The maximum length is 1000 characters.<br/>
        /// Example: A cute baby sea otter wearing a beret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// The model to use for image generation. Only `dall-e-2` is supported at this time.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: dall-e-2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::System.AnyOf<string?, global::OpenAI.CreateImageEditRequestModel?>? Model { get; set; } = global::OpenAI.CreateImageEditRequestModel.DallE2;

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; } = 1;

        /// <summary>
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CreateImageEditRequestSizeJsonConverter))]
        public global::OpenAI.CreateImageEditRequestSize? Size { get; set; } = global::OpenAI.CreateImageEditRequestSize._1024x1024;

        /// <summary>
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter))]
        public global::OpenAI.CreateImageEditRequestResponseFormat? ResponseFormat { get; set; } = global::OpenAI.CreateImageEditRequestResponseFormat.Url;

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).<br/>
        /// Example: user-1234
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}