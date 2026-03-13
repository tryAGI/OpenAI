
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Multipart parameters for creating a new video generation job.
    /// </summary>
    public sealed partial class CreateVideoMultipartBody
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_reference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.ImageRefParam2>))]
        public global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>? InputReference { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoMultipartBody" /> class.
        /// </summary>
        /// <param name="model">
        /// The video generation model to use (allowed values: sora-2, sora-2-pro). Defaults to `sora-2`.
        /// </param>
        /// <param name="prompt">
        /// Text prompt that describes the video to generate.
        /// </param>
        /// <param name="inputReference"></param>
        /// <param name="seconds">
        /// Clip duration in seconds (allowed values: 4, 8, 12). Defaults to 4 seconds.
        /// </param>
        /// <param name="size">
        /// Output resolution formatted as width x height (allowed values: 720x1280, 1280x720, 1024x1792, 1792x1024). Defaults to 720x1280.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoMultipartBody(
            string prompt,
            global::tryAGI.OpenAI.VideoModel? model,
            global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.ImageRefParam2>? inputReference,
            global::tryAGI.OpenAI.VideoSeconds? seconds,
            global::tryAGI.OpenAI.VideoSize? size)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.InputReference = inputReference;
            this.Seconds = seconds;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoMultipartBody" /> class.
        /// </summary>
        public CreateVideoMultipartBody()
        {
        }
    }
}