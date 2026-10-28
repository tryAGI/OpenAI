
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Aggregated usage details for billable tools that ran while generating the response.
    /// </summary>
    public sealed partial class BetaResponseToolUsage
    {
        /// <summary>
        /// Aggregated usage statistics for image generation tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_gen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaImageGenToolUsage ImageGen { get; set; }

        /// <summary>
        /// Aggregated billable usage statistics for web search tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaWebSearchUsage WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolUsage" /> class.
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
        public BetaResponseToolUsage(
            global::tryAGI.OpenAI.BetaImageGenToolUsage imageGen,
            global::tryAGI.OpenAI.BetaWebSearchUsage webSearch)
        {
            this.ImageGen = imageGen ?? throw new global::System.ArgumentNullException(nameof(imageGen));
            this.WebSearch = webSearch ?? throw new global::System.ArgumentNullException(nameof(webSearch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolUsage" /> class.
        /// </summary>
        public BetaResponseToolUsage()
        {
        }

    }
}