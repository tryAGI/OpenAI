
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// JSON parameters for editing an existing generated video.
    /// </summary>
    public sealed partial class CreateVideoEditJsonBody
    {
        /// <summary>
        /// Reference to the completed video to edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.VideoReferenceInputParam Video { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoEditJsonBody" /> class.
        /// </summary>
        /// <param name="video">
        /// Reference to the completed video to edit.
        /// </param>
        /// <param name="prompt">
        /// Text prompt that describes how to edit the source video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoEditJsonBody(
            global::tryAGI.OpenAI.VideoReferenceInputParam video,
            string prompt)
        {
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoEditJsonBody" /> class.
        /// </summary>
        public CreateVideoEditJsonBody()
        {
        }
    }
}