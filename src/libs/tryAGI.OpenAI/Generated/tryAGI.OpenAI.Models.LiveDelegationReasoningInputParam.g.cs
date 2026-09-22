
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reasoning options for Responses requests made on behalf of the Live session.
    /// </summary>
    public sealed partial class LiveDelegationReasoningInputParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::tryAGI.OpenAI.LiveReasoningEffort? Effort { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::tryAGI.OpenAI.LiveReasoningSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDelegationReasoningInputParam" /> class.
        /// </summary>
        /// <param name="effort"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDelegationReasoningInputParam(
            global::tryAGI.OpenAI.LiveReasoningEffort? effort,
            global::tryAGI.OpenAI.LiveReasoningSummary? summary)
        {
            this.Effort = effort;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDelegationReasoningInputParam" /> class.
        /// </summary>
        public LiveDelegationReasoningInputParam()
        {
        }

    }
}