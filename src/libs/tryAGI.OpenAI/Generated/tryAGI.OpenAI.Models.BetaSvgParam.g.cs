
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaSvgParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.BetaSvgReasoningParam? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSvgParam" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="reasoning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSvgParam(
            string? model,
            global::tryAGI.OpenAI.BetaSvgReasoningParam? reasoning)
        {
            this.Model = model;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSvgParam" /> class.
        /// </summary>
        public BetaSvgParam()
        {
        }

    }
}