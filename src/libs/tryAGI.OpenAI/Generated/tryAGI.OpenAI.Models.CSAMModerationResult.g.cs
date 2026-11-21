
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CSAMModerationResult
    {
        /// <summary>
        /// Whether either CSAM category was flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// Whether the image was flagged in each category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CSAMCategoryFlags Categories { get; set; }

        /// <summary>
        /// The classifier score for each category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CSAMCategoryScores CategoryScores { get; set; }

        /// <summary>
        /// The input types evaluated for each category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_applied_input_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CSAMCategoryAppliedInputTypes CategoryAppliedInputTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CSAMModerationResult" /> class.
        /// </summary>
        /// <param name="flagged">
        /// Whether either CSAM category was flagged.
        /// </param>
        /// <param name="categories">
        /// Whether the image was flagged in each category.
        /// </param>
        /// <param name="categoryScores">
        /// The classifier score for each category.
        /// </param>
        /// <param name="categoryAppliedInputTypes">
        /// The input types evaluated for each category.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CSAMModerationResult(
            bool flagged,
            global::tryAGI.OpenAI.CSAMCategoryFlags categories,
            global::tryAGI.OpenAI.CSAMCategoryScores categoryScores,
            global::tryAGI.OpenAI.CSAMCategoryAppliedInputTypes categoryAppliedInputTypes)
        {
            this.Flagged = flagged;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.CategoryScores = categoryScores ?? throw new global::System.ArgumentNullException(nameof(categoryScores));
            this.CategoryAppliedInputTypes = categoryAppliedInputTypes ?? throw new global::System.ArgumentNullException(nameof(categoryAppliedInputTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CSAMModerationResult" /> class.
        /// </summary>
        public CSAMModerationResult()
        {
        }

    }
}