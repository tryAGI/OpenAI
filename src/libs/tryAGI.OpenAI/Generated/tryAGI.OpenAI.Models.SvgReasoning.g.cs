
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reasoning settings for the SVG author, independent of image complexity. Omitted or null effort uses the author model's default. Supported efforts depend on the selected author model.
    /// </summary>
    public sealed partial class SvgReasoning
    {
        /// <summary>
        /// Controls how much effort the SVG author spends on reasoning. Uses the author model's default when omitted or null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::tryAGI.OpenAI.ReasoningEffortEnum2? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Controls how much effort the SVG author spends on reasoning. Uses the author model's default when omitted or null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgReasoning(
            global::tryAGI.OpenAI.ReasoningEffortEnum2? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgReasoning" /> class.
        /// </summary>
        public SvgReasoning()
        {
        }

    }
}