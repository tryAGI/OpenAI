
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An image generation request made by the model.
    /// </summary>
    public sealed partial class ImageGenToolCall
    {
        /// <summary>
        /// The type of the image generation call. Always `image_generation_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.ImageGenToolCallType Type { get; set; }

        /// <summary>
        /// The unique ID of the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageGenToolCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>? Size { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public global::tryAGI.OpenAI.ImageGenToolCallQuality? Quality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::tryAGI.OpenAI.ImageGenActionEnum? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::tryAGI.OpenAI.ImageBackground? Background { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::tryAGI.OpenAI.ImageOutputFormat? OutputFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revised_prompt")]
        public string? RevisedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the image generation call.
        /// </param>
        /// <param name="status">
        /// The status of the image generation call.
        /// </param>
        /// <param name="type">
        /// The type of the image generation call. Always `image_generation_call`.
        /// </param>
        /// <param name="result"></param>
        /// <param name="size"></param>
        /// <param name="quality"></param>
        /// <param name="action"></param>
        /// <param name="background"></param>
        /// <param name="outputFormat"></param>
        /// <param name="revisedPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenToolCall(
            string id,
            global::tryAGI.OpenAI.ImageGenToolCallStatus status,
            global::tryAGI.OpenAI.ImageGenToolCallType type,
            string? result,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>? size,
            global::tryAGI.OpenAI.ImageGenToolCallQuality? quality,
            global::tryAGI.OpenAI.ImageGenActionEnum? action,
            global::tryAGI.OpenAI.ImageBackground? background,
            global::tryAGI.OpenAI.ImageOutputFormat? outputFormat,
            string? revisedPrompt)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Result = result;
            this.Size = size;
            this.Quality = quality;
            this.Action = action;
            this.Background = background;
            this.OutputFormat = outputFormat;
            this.RevisedPrompt = revisedPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolCall" /> class.
        /// </summary>
        public ImageGenToolCall()
        {
        }

    }
}