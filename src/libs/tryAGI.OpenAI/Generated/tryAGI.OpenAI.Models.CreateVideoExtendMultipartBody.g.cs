
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Multipart parameters for extending an existing generated video.
    /// </summary>
    public sealed partial class CreateVideoExtendMultipartBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]> Video { get; set; }

        /// <summary>
        /// Updated text prompt that directs the extension generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Length of the newly generated extension segment in seconds (allowed values: 4, 8, 12, 16, 20).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VideoSecondsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VideoSeconds Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoExtendMultipartBody" /> class.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="prompt">
        /// Updated text prompt that directs the extension generation.
        /// </param>
        /// <param name="seconds">
        /// Length of the newly generated extension segment in seconds (allowed values: 4, 8, 12, 16, 20).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoExtendMultipartBody(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.VideoReferenceInputParam, byte[]> video,
            string prompt,
            global::tryAGI.OpenAI.VideoSeconds seconds)
        {
            this.Video = video;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoExtendMultipartBody" /> class.
        /// </summary>
        public CreateVideoExtendMultipartBody()
        {
        }
    }
}