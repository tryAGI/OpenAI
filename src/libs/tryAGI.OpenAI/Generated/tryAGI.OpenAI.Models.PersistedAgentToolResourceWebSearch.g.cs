
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Web search.
    /// </summary>
    public sealed partial class PersistedAgentToolResourceWebSearch
    {
        /// <summary>
        /// The type of the object. Always `web_search`.<br/>
        /// Default Value: web_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType.WebSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceWebSearchTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType Type { get; set; } = global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType.WebSearch;

        /// <summary>
        /// The source used for web search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchModeResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchModeResource Mode { get; set; }

        /// <summary>
        /// The amount of search context made available to the model. Defaults to `medium`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebSearchContextSizeResource ContextSize { get; set; }

        /// <summary>
        /// Allowed search domains, or `null` when the search is unrestricted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Approximate location used to localize search results, if provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::tryAGI.OpenAI.WebSearchLocationResource? Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolResourceWebSearch" /> class.
        /// </summary>
        /// <param name="mode">
        /// The source used for web search results.
        /// </param>
        /// <param name="contextSize">
        /// The amount of search context made available to the model. Defaults to `medium`.
        /// </param>
        /// <param name="allowedDomains">
        /// Allowed search domains, or `null` when the search is unrestricted.
        /// </param>
        /// <param name="location">
        /// Approximate location used to localize search results, if provided.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `web_search`.<br/>
        /// Default Value: web_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedAgentToolResourceWebSearch(
            global::tryAGI.OpenAI.WebSearchModeResource mode,
            global::tryAGI.OpenAI.WebSearchContextSizeResource contextSize,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::tryAGI.OpenAI.WebSearchLocationResource? location,
            global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType type = global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType.WebSearch)
        {
            this.Type = type;
            this.Mode = mode;
            this.ContextSize = contextSize;
            this.AllowedDomains = allowedDomains;
            this.Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolResourceWebSearch" /> class.
        /// </summary>
        public PersistedAgentToolResourceWebSearch()
        {
        }

    }
}