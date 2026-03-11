
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Usage statistics related to the run step. This value will be `null` while the run step's status is `in_progress`.
    /// </summary>
    public sealed partial class RunStepCompletionUsageVariant1
    {
        /// <summary>
        /// Number of completion tokens used over the course of the run step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Number of prompt tokens used over the course of the run step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// Total number of tokens used (prompt + completion).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepCompletionUsageVariant1" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Number of completion tokens used over the course of the run step.
        /// </param>
        /// <param name="promptTokens">
        /// Number of prompt tokens used over the course of the run step.
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used (prompt + completion).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepCompletionUsageVariant1(
            int completionTokens,
            int promptTokens,
            int totalTokens)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepCompletionUsageVariant1" /> class.
        /// </summary>
        public RunStepCompletionUsageVariant1()
        {
        }
    }
}