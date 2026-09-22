
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A web search call produced by the agent.
    /// </summary>
    public sealed partial class WebSearchCallItemResource
    {
        /// <summary>
        /// The item type. Always `web_search_call`.<br/>
        /// Default Value: web_search_call
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebSearchCallItemResourceType.WebSearchCall</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchCallItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchCallItemResourceType Type { get; set; } = global::tryAGI.OpenAI.WebSearchCallItemResourceType.WebSearchCall;

        /// <summary>
        /// The ID of the web search call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The status of the web search call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OutputItemStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OutputItemStatusResource Status { get; set; }

        /// <summary>
        /// The action performed by the web search tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::tryAGI.OpenAI.WebSearchActionResource? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchCallItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the web search call.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="status">
        /// The status of the web search call.
        /// </param>
        /// <param name="action">
        /// The action performed by the web search tool.
        /// </param>
        /// <param name="type">
        /// The item type. Always `web_search_call`.<br/>
        /// Default Value: web_search_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchCallItemResource(
            string id,
            string turnId,
            global::tryAGI.OpenAI.OutputItemStatusResource status,
            global::tryAGI.OpenAI.WebSearchActionResource? action,
            global::tryAGI.OpenAI.WebSearchCallItemResourceType type = global::tryAGI.OpenAI.WebSearchCallItemResourceType.WebSearchCall)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Status = status;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchCallItemResource" /> class.
        /// </summary>
        public WebSearchCallItemResource()
        {
        }

    }
}