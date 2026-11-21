
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The results of a web search tool call. See the<br/>
    /// [web search guide](https://developers.openai.com/api/docs/guides/tools-web-search) for more information.
    /// </summary>
    public sealed partial class WebSearchToolCall
    {
        /// <summary>
        /// The unique ID of the web search tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of the web search tool call. Always `web_search_call`.
        /// </summary>
        /// <default>"web_search_call"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_search_call";

        /// <summary>
        /// The status of the web search tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchCallStatus Status { get; set; }

        /// <summary>
        /// An object describing the specific action taken in this web search call.<br/>
        /// Includes details on how the model used the web (search, open_page, find_in_page).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchToolCallAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the web search tool call.
        /// </param>
        /// <param name="status">
        /// The status of the web search tool call.
        /// </param>
        /// <param name="action">
        /// An object describing the specific action taken in this web search call.<br/>
        /// Includes details on how the model used the web (search, open_page, find_in_page).
        /// </param>
        /// <param name="type">
        /// The type of the web search tool call. Always `web_search_call`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolCall(
            string id,
            global::tryAGI.OpenAI.WebSearchCallStatus status,
            global::tryAGI.OpenAI.WebSearchToolCallAction? action,
            string type = "web_search_call")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Status = status;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolCall" /> class.
        /// </summary>
        public WebSearchToolCall()
        {
        }

    }
}