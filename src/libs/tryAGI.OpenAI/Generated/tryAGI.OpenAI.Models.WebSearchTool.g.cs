
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Search the Internet for sources related to the prompt. Learn more about the<br/>
    /// [web search tool](https://platform.openai.com/docs/guides/tools-web-search).
    /// </summary>
    public sealed partial class WebSearchTool
    {
        /// <summary>
        /// Filters for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::tryAGI.OpenAI.WebSearchToolFilters? Filters { get; set; }

        /// <summary>
        /// High level guidance for the amount of context window space to use for the search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolSearchContextSizeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchToolSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// The type of the web search tool. One of `web_search` or `web_search_2025_08_26`.<br/>
        /// Default Value: web_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebSearchToolType.WebSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchToolType Type { get; set; } = global::tryAGI.OpenAI.WebSearchToolType.WebSearch;

        /// <summary>
        /// The approximate location of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::tryAGI.OpenAI.WebSearchApproximateLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        /// <param name="filters">
        /// Filters for the search.
        /// </param>
        /// <param name="searchContextSize">
        /// High level guidance for the amount of context window space to use for the search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="type">
        /// The type of the web search tool. One of `web_search` or `web_search_2025_08_26`.<br/>
        /// Default Value: web_search
        /// </param>
        /// <param name="userLocation">
        /// The approximate location of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchTool(
            global::tryAGI.OpenAI.WebSearchToolType type,
            global::tryAGI.OpenAI.WebSearchToolFilters? filters,
            global::tryAGI.OpenAI.WebSearchToolSearchContextSize? searchContextSize,
            global::tryAGI.OpenAI.WebSearchApproximateLocation? userLocation)
        {
            this.Type = type;
            this.Filters = filters;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        public WebSearchTool()
        {
        }
    }
}