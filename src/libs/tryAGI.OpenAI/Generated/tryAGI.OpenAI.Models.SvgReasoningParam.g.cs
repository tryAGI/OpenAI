
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reasoning effort for SVG authoring. When omitted, uses the author model's default in both Images and Responses.
    /// </summary>
    public sealed partial class SvgReasoningParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnum2JsonConverter))]
        public global::tryAGI.OpenAI.ReasoningEffortEnum2? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgReasoningParam" /> class.
        /// </summary>
        /// <param name="effort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgReasoningParam(
            global::tryAGI.OpenAI.ReasoningEffortEnum2? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgReasoningParam" /> class.
        /// </summary>
        public SvgReasoningParam()
        {
        }

    }
}