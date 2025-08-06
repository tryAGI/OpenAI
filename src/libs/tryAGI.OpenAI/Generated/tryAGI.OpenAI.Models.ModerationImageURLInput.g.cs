
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An object describing an image to classify.
    /// </summary>
    public sealed partial class ModerationImageURLInput
    {
        /// <summary>
        /// Contains either an image URL or a data URL for a base64 encoded image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ModerationImageURLInputImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Always `image_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ModerationImageURLInputTypeJsonConverter))]
        public global::tryAGI.OpenAI.ModerationImageURLInputType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationImageURLInput" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Contains either an image URL or a data URL for a base64 encoded image.
        /// </param>
        /// <param name="type">
        /// Always `image_url`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationImageURLInput(
            global::tryAGI.OpenAI.ModerationImageURLInputImageUrl imageUrl,
            global::tryAGI.OpenAI.ModerationImageURLInputType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationImageURLInput" /> class.
        /// </summary>
        public ModerationImageURLInput()
        {
        }
    }
}