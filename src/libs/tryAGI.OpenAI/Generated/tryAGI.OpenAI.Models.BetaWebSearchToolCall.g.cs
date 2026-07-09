
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The results of a web search tool call. See the<br/>
    /// [web search guide](/docs/guides/tools-web-search) for more information.
    /// </summary>
    public sealed partial class BetaWebSearchToolCall
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaWebSearchToolCallType Type { get; set; }

        /// <summary>
        /// The status of the web search tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaWebSearchToolCallStatus Status { get; set; }

        /// <summary>
        /// An object describing the specific action taken in this web search call.<br/>
        /// Includes details on how the model used the web (search, open_page, find_in_page).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaWebSearchToolCallAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebSearchToolCall" /> class.
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
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the web search tool call. Always `web_search_call`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWebSearchToolCall(
            string id,
            global::tryAGI.OpenAI.BetaWebSearchToolCallStatus status,
            global::tryAGI.OpenAI.BetaWebSearchToolCallAction action,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaWebSearchToolCallType type)
        {
            this.Agent = agent;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Status = status;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWebSearchToolCall" /> class.
        /// </summary>
        public BetaWebSearchToolCall()
        {
        }

    }
}