
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for editing an existing generated video.
    /// </summary>
    public sealed partial class CreateVideoEditMultipartBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam> Video { get; set; }

        /// <summary>
        /// Text prompt that describes how to edit the source video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoEditMultipartBody" /> class.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="prompt">
        /// Text prompt that describes how to edit the source video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoEditMultipartBody(
            global::tryAGI.OpenAI.OneOf<byte[], global::tryAGI.OpenAI.VideoReferenceInputParam> video,
            string prompt)
        {
            this.Video = video;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoEditMultipartBody" /> class.
        /// </summary>
        public CreateVideoEditMultipartBody()
        {
        }
    }
}