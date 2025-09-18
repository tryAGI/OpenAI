
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// This tool searches the web for relevant results to use in a response. Learn more about the [web search tool](https://platform.openai.com/docs/guides/tools-web-search).
    /// </summary>
    public sealed partial class WebSearchPreviewTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SearchContextSizeJsonConverter))]
        public global::tryAGI.OpenAI.SearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// The type of the web search tool. One of `web_search_preview` or `web_search_preview_2025_03_11`.<br/>
        /// Default Value: web_search_preview
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebSearchPreviewToolType.WebSearchPreview</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchPreviewToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchPreviewToolType Type { get; set; } = global::tryAGI.OpenAI.WebSearchPreviewToolType.WebSearchPreview;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public object? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPreviewTool" /> class.
        /// </summary>
        /// <param name="searchContextSize"></param>
        /// <param name="type">
        /// The type of the web search tool. One of `web_search_preview` or `web_search_preview_2025_03_11`.<br/>
        /// Default Value: web_search_preview
        /// </param>
        /// <param name="userLocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchPreviewTool(
            global::tryAGI.OpenAI.WebSearchPreviewToolType type,
            global::tryAGI.OpenAI.SearchContextSize? searchContextSize,
            object? userLocation)
        {
            this.Type = type;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPreviewTool" /> class.
        /// </summary>
        public WebSearchPreviewTool()
        {
        }
    }
}