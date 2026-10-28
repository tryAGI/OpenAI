
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Usage details for web search requests that ran while generating the response.
    /// </summary>
    public sealed partial class WebSearchUsage
    {
        /// <summary>
        /// The number of billable web search requests issued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchUsage" /> class.
        /// </summary>
        /// <param name="numRequests">
        /// The number of billable web search requests issued.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchUsage(
            int numRequests)
        {
            this.NumRequests = numRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchUsage" /> class.
        /// </summary>
        public WebSearchUsage()
        {
        }

    }
}