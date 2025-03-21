
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// This tool searches the web for relevant results to use in a response.<br/>
    /// Learn more about the [web search tool](/docs/guides/tools-web-search).
    /// </summary>
    public sealed partial class WebSearchTool
    {
        /// <summary>
        /// The type of the web search tool. One of:<br/>
        /// - `web_search_preview`<br/>
        /// - `web_search_preview_2025_03_11`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.WebSearchLocation, global::tryAGI.OpenAI.WebSearchToolUserLocation>))]
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.WebSearchLocation, global::tryAGI.OpenAI.WebSearchToolUserLocation>? UserLocation { get; set; }

        /// <summary>
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchContextSize? SearchContextSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the web search tool. One of:<br/>
        /// - `web_search_preview`<br/>
        /// - `web_search_preview_2025_03_11`
        /// </param>
        /// <param name="userLocation"></param>
        /// <param name="searchContextSize">
        /// High level guidance for the amount of context window space to use for the <br/>
        /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
        /// Default Value: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchTool(
            global::tryAGI.OpenAI.WebSearchToolType type,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.WebSearchLocation, global::tryAGI.OpenAI.WebSearchToolUserLocation>? userLocation,
            global::tryAGI.OpenAI.WebSearchContextSize? searchContextSize)
        {
            this.Type = type;
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