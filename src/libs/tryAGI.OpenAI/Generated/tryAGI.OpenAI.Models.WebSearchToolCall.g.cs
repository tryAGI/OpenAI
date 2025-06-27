
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// An object describing the specific action taken in this web search call.<br/>
        /// Includes details on how the model used the web (search, open_page, find).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.WebSearchActionSearch, global::tryAGI.OpenAI.WebSearchActionOpenPage, global::tryAGI.OpenAI.WebSearchActionFind>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.WebSearchActionSearch, global::tryAGI.OpenAI.WebSearchActionOpenPage, global::tryAGI.OpenAI.WebSearchActionFind> Action { get; set; }

        /// <summary>
        /// The unique ID of the web search tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the web search tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchToolCallStatus Status { get; set; }

        /// <summary>
        /// The type of the web search tool call. Always `web_search_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolCall" /> class.
        /// </summary>
        /// <param name="action">
        /// An object describing the specific action taken in this web search call.<br/>
        /// Includes details on how the model used the web (search, open_page, find).
        /// </param>
        /// <param name="id">
        /// The unique ID of the web search tool call.
        /// </param>
        /// <param name="status">
        /// The status of the web search tool call.
        /// </param>
        /// <param name="type">
        /// The type of the web search tool call. Always `web_search_call`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolCall(
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.WebSearchActionSearch, global::tryAGI.OpenAI.WebSearchActionOpenPage, global::tryAGI.OpenAI.WebSearchActionFind> action,
            string id,
            global::tryAGI.OpenAI.WebSearchToolCallStatus status,
            global::tryAGI.OpenAI.WebSearchToolCallType type)
        {
            this.Action = action;
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