
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A moderation result produced for the response input or output.
    /// </summary>
    public sealed partial class ModerationResultBody
    {
        /// <summary>
        /// The object type, which was always `moderation_result` for successful moderation results.<br/>
        /// Default Value: moderation_result
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ModerationResultBodyType.ModerationResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.ModerationResultBodyType Type { get; set; } = global::tryAGI.OpenAI.ModerationResultBodyType.ModerationResult;

        /// <summary>
        /// The moderation model that produced this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A boolean indicating whether the content was flagged by any category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// A dictionary of moderation categories to booleans, True if the input is flagged under this category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, bool> Categories { get; set; }

        /// <summary>
        /// A dictionary of moderation categories to scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> CategoryScores { get; set; }

        /// <summary>
        /// Which modalities of input are reflected by the score for each category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_applied_input_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>> CategoryAppliedInputTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationResultBody" /> class.
        /// </summary>
        /// <param name="model">
        /// The moderation model that produced this result.
        /// </param>
        /// <param name="flagged">
        /// A boolean indicating whether the content was flagged by any category.
        /// </param>
        /// <param name="categories">
        /// A dictionary of moderation categories to booleans, True if the input is flagged under this category.
        /// </param>
        /// <param name="categoryScores">
        /// A dictionary of moderation categories to scores.
        /// </param>
        /// <param name="categoryAppliedInputTypes">
        /// Which modalities of input are reflected by the score for each category.
        /// </param>
        /// <param name="type">
        /// The object type, which was always `moderation_result` for successful moderation results.<br/>
        /// Default Value: moderation_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationResultBody(
            string model,
            bool flagged,
            global::System.Collections.Generic.Dictionary<string, bool> categories,
            global::System.Collections.Generic.Dictionary<string, double> categoryScores,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>> categoryAppliedInputTypes,
            global::tryAGI.OpenAI.ModerationResultBodyType type = global::tryAGI.OpenAI.ModerationResultBodyType.ModerationResult)
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Flagged = flagged;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.CategoryScores = categoryScores ?? throw new global::System.ArgumentNullException(nameof(categoryScores));
            this.CategoryAppliedInputTypes = categoryAppliedInputTypes ?? throw new global::System.ArgumentNullException(nameof(categoryAppliedInputTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationResultBody" /> class.
        /// </summary>
        public ModerationResultBody()
        {
        }

    }
}