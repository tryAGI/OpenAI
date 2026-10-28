
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Aggregated usage details for billable tools that ran while generating the response.
    /// </summary>
    public sealed partial class ResponseToolUsage
    {
        /// <summary>
        /// Aggregated usage statistics for image generation tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ImageGenToolUsage ImageGen { get; set; }

        /// <summary>
        /// Aggregated billable usage statistics for web search tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchUsage WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolUsage" /> class.
        /// </summary>
        /// <param name="imageGen">
        /// Aggregated usage statistics for image generation tool calls.
        /// </param>
        /// <param name="webSearch">
        /// Aggregated billable usage statistics for web search tool calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseToolUsage(
            global::tryAGI.OpenAI.ImageGenToolUsage imageGen,
            global::tryAGI.OpenAI.WebSearchUsage webSearch)
        {
            this.ImageGen = imageGen ?? throw new global::System.ArgumentNullException(nameof(imageGen));
            this.WebSearch = webSearch ?? throw new global::System.ArgumentNullException(nameof(webSearch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolUsage" /> class.
        /// </summary>
        public ResponseToolUsage()
        {
        }

    }
}