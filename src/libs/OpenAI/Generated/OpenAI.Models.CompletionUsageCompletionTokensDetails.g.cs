
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Breakdown of tokens used in a completion.
    /// </summary>
    public sealed partial class CompletionUsageCompletionTokensDetails
    {
        /// <summary>
        /// Tokens generated by the model for reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}