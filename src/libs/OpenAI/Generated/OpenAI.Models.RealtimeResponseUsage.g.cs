
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Usage statistics for the response.
    /// </summary>
    public sealed partial class RealtimeResponseUsage
    {
        /// <summary>
        /// The total number of tokens used.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// The number of input tokens used.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// The number of output tokens used.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The total number of tokens used.<br/>
        /// Example: 50
        /// </param>
        /// <param name="inputTokens">
        /// The number of input tokens used.<br/>
        /// Example: 20
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens used.<br/>
        /// Example: 30
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseUsage(
            int? totalTokens,
            int? inputTokens,
            int? outputTokens)
        {
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsage" /> class.
        /// </summary>
        public RealtimeResponseUsage()
        {
        }
    }
}