
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Updates to reasoning configuration. Only effort is supported.
    /// </summary>
    public sealed partial class ResponseConfigurationUpdateItemParamReasoning
    {
        /// <summary>
        /// The reasoning effort to use for subsequent responses until another<br/>
        /// configuration update replaces it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::tryAGI.OpenAI.ReasoningEffortEnum? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfigurationUpdateItemParamReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// The reasoning effort to use for subsequent responses until another<br/>
        /// configuration update replaces it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseConfigurationUpdateItemParamReasoning(
            global::tryAGI.OpenAI.ReasoningEffortEnum? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseConfigurationUpdateItemParamReasoning" /> class.
        /// </summary>
        public ResponseConfigurationUpdateItemParamReasoning()
        {
        }

    }
}