
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A breakdown of output token usage for a session or turn.
    /// </summary>
    public sealed partial class OutputTokensDetailsResource
    {
        /// <summary>
        /// The number of output tokens used for reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTokensDetailsResource" /> class.
        /// </summary>
        /// <param name="reasoningTokens">
        /// The number of output tokens used for reasoning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTokensDetailsResource(
            long reasoningTokens)
        {
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTokensDetailsResource" /> class.
        /// </summary>
        public OutputTokensDetailsResource()
        {
        }

    }
}