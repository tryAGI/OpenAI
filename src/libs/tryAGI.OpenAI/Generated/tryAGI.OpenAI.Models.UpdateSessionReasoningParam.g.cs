
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reasoning effort for subsequent turns. The reasoning summary stays unchanged.
    /// </summary>
    public sealed partial class UpdateSessionReasoningParam
    {
        /// <summary>
        /// Omit to keep the current effort. Null selects the model's default effort.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::tryAGI.OpenAI.ReasoningEffortParam? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionReasoningParam" /> class.
        /// </summary>
        /// <param name="effort">
        /// Omit to keep the current effort. Null selects the model's default effort.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSessionReasoningParam(
            global::tryAGI.OpenAI.ReasoningEffortParam? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionReasoningParam" /> class.
        /// </summary>
        public UpdateSessionReasoningParam()
        {
        }

    }
}