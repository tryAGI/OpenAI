
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageGenToolCallModerationDetails
    {
        /// <summary>
        /// The stage where moderation blocked the image generation call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation_stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallModerationDetailsModerationStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage ModerationStage { get; set; }

        /// <summary>
        /// Public moderation categories. New category values may be added over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolCallModerationDetails" /> class.
        /// </summary>
        /// <param name="moderationStage">
        /// The stage where moderation blocked the image generation call.
        /// </param>
        /// <param name="categories">
        /// Public moderation categories. New category values may be added over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenToolCallModerationDetails(
            global::tryAGI.OpenAI.ImageGenToolCallModerationDetailsModerationStage moderationStage,
            global::System.Collections.Generic.IList<string> categories)
        {
            this.ModerationStage = moderationStage;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenToolCallModerationDetails" /> class.
        /// </summary>
        public ImageGenToolCallModerationDetails()
        {
        }

    }
}