
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Parameters for creating a character from an uploaded video.
    /// </summary>
    public sealed partial class CreateVideoCharacterBody
    {
        /// <summary>
        /// Video file used to create a character.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Video { get; set; }

        /// <summary>
        /// Video file used to create a character.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Videoname { get; set; }

        /// <summary>
        /// Display name for this API character.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoCharacterBody" /> class.
        /// </summary>
        /// <param name="video">
        /// Video file used to create a character.
        /// </param>
        /// <param name="videoname">
        /// Video file used to create a character.
        /// </param>
        /// <param name="name">
        /// Display name for this API character.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoCharacterBody(
            byte[] video,
            string videoname,
            string name)
        {
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
            this.Videoname = videoname ?? throw new global::System.ArgumentNullException(nameof(videoname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoCharacterBody" /> class.
        /// </summary>
        public CreateVideoCharacterBody()
        {
        }
    }
}