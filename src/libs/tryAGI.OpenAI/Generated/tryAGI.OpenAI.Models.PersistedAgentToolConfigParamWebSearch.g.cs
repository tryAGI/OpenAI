
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Web search.
    /// </summary>
    public sealed partial class PersistedAgentToolConfigParamWebSearch
    {
        /// <summary>
        /// The type of the object. Always `web_search`.<br/>
        /// Default Value: web_search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType.WebSearch</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamWebSearchTypeJsonConverter))]
        public global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType Type { get; set; } = global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType.WebSearch;

        /// <summary>
        /// The source used for web search results. Defaults to `live`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public global::tryAGI.OpenAI.WebSearchModeParam? Mode { get; set; }

        /// <summary>
        /// The amount of search context made available to the model. Defaults to `medium`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_size")]
        public global::tryAGI.OpenAI.WebSearchContextSizeParam? ContextSize { get; set; }

        /// <summary>
        /// Domains the search may include.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Approximate location used to localize search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::tryAGI.OpenAI.WebSearchLocationParam? Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolConfigParamWebSearch" /> class.
        /// </summary>
        /// <param name="mode">
        /// The source used for web search results. Defaults to `live`.
        /// </param>
        /// <param name="contextSize">
        /// The amount of search context made available to the model. Defaults to `medium`.
        /// </param>
        /// <param name="allowedDomains">
        /// Domains the search may include.
        /// </param>
        /// <param name="location">
        /// Approximate location used to localize search results.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `web_search`.<br/>
        /// Default Value: web_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedAgentToolConfigParamWebSearch(
            global::tryAGI.OpenAI.WebSearchModeParam? mode,
            global::tryAGI.OpenAI.WebSearchContextSizeParam? contextSize,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::tryAGI.OpenAI.WebSearchLocationParam? location,
            global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType type = global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType.WebSearch)
        {
            this.Type = type;
            this.Mode = mode;
            this.ContextSize = contextSize;
            this.AllowedDomains = allowedDomains;
            this.Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedAgentToolConfigParamWebSearch" /> class.
        /// </summary>
        public PersistedAgentToolConfigParamWebSearch()
        {
        }

    }
}