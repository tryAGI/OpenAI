
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The results of a web search tool call. See the <br/>
    /// [web search guide](/docs/guides/tools-web-search) for more information.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchToolCallType Type { get; set; }

        /// <summary>
        /// The status of the web search tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchToolCallStatus Status { get; set; }

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
        /// <param name="type">
        /// The type of the web search tool call. Always `web_search_call`.
        /// </param>
        /// <param name="status">
        /// The status of the web search tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolCall(
            string id,
            global::tryAGI.OpenAI.WebSearchToolCallStatus status,
            global::tryAGI.OpenAI.WebSearchToolCallType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolCall" /> class.
        /// </summary>
        public WebSearchToolCall()
        {
        }
    }
}