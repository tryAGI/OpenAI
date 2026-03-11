
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Search the Internet for sources related to the prompt. Learn more about the<br/>
    /// [web search tool](/docs/guides/tools-web-search).
    /// </summary>
    public sealed partial class WebSearchTool
    {
        /// <summary>
        /// The type of the web search tool. One of `web_search` or `web_search_2025_08_26`.<br/>
        /// Default Value: web_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebSearchToolType.WebSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.WebSearchToolType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::tryAGI.OpenAI.WebSearchToolFilters2? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1? UserLocation { get; set; }

        /// <summary>
        /// High level guidance for the amount of context window space to use for the search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolSearchContextSizeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchToolSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the web search tool. One of `web_search` or `web_search_2025_08_26`.<br/>
        /// Default Value: web_search
        /// </param>
        /// <param name="filters"></param>
        /// <param name="userLocation"></param>
        /// <param name="searchContextSize">
        /// High level guidance for the amount of context window space to use for the search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchTool(
            global::tryAGI.OpenAI.WebSearchToolType type,
            global::tryAGI.OpenAI.WebSearchToolFilters2? filters,
            global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1? userLocation,
            global::tryAGI.OpenAI.WebSearchToolSearchContextSize? searchContextSize)
        {
            this.Type = type;
            this.Filters = filters;
            this.UserLocation = userLocation;
            this.SearchContextSize = searchContextSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        public WebSearchTool()
        {
        }
    }
}