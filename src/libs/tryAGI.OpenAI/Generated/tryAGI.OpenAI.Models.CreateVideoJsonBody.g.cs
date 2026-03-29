
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// JSON parameters for creating a new video generation job.
    /// </summary>
    public sealed partial class CreateVideoJsonBody
    {
        /// <summary>
        /// The video generation model to use (allowed values: sora-2, sora-2-pro). Defaults to `sora-2`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VideoModelJsonConverter))]
        public global::tryAGI.OpenAI.VideoModel? Model { get; set; }

        /// <summary>
        /// Text prompt that describes the video to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional reference object that guides generation. Provide exactly one of `image_url` or `file_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_reference")]
        public global::tryAGI.OpenAI.ImageRefParam2? InputReference { get; set; }

        /// <summary>
        /// Clip duration in seconds (allowed values: 4, 8, 12). Defaults to 4 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VideoSecondsJsonConverter))]
        public global::tryAGI.OpenAI.VideoSeconds? Seconds { get; set; }

        /// <summary>
        /// Output resolution formatted as width x height (allowed values: 720x1280, 1280x720, 1024x1792, 1792x1024). Defaults to 720x1280.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VideoSizeJsonConverter))]
        public global::tryAGI.OpenAI.VideoSize? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoJsonBody" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt that describes the video to generate.
        /// </param>
        /// <param name="model">
        /// The video generation model to use (allowed values: sora-2, sora-2-pro). Defaults to `sora-2`.
        /// </param>
        /// <param name="inputReference">
        /// Optional reference object that guides generation. Provide exactly one of `image_url` or `file_id`.
        /// </param>
        /// <param name="seconds">
        /// Clip duration in seconds (allowed values: 4, 8, 12). Defaults to 4 seconds.
        /// </param>
        /// <param name="size">
        /// Output resolution formatted as width x height (allowed values: 720x1280, 1280x720, 1024x1792, 1792x1024). Defaults to 720x1280.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoJsonBody(
            string prompt,
            global::tryAGI.OpenAI.VideoModel? model,
            global::tryAGI.OpenAI.ImageRefParam2? inputReference,
            global::tryAGI.OpenAI.VideoSeconds? seconds,
            global::tryAGI.OpenAI.VideoSize? size)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.InputReference = inputReference;
            this.Seconds = seconds;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoJsonBody" /> class.
        /// </summary>
        public CreateVideoJsonBody()
        {
        }
    }
}