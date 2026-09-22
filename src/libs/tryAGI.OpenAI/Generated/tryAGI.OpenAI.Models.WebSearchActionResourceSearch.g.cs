
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A search query or group of search queries.
    /// </summary>
    public sealed partial class WebSearchActionResourceSearch
    {
        /// <summary>
        /// The type of the object. Always `search`.<br/>
        /// Default Value: search
        /// </summary>
        /// <default>global::tryAGI.OpenAI.WebSearchActionResourceSearchType.Search</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceSearchTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionResourceSearchType Type { get; set; } = global::tryAGI.OpenAI.WebSearchActionResourceSearchType.Search;

        /// <summary>
        /// The search query, when a single query was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The search queries, when multiple queries were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionResourceSearch" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query, when a single query was used.
        /// </param>
        /// <param name="queries">
        /// The search queries, when multiple queries were used.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `search`.<br/>
        /// Default Value: search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionResourceSearch(
            string? query,
            global::System.Collections.Generic.IList<string>? queries,
            global::tryAGI.OpenAI.WebSearchActionResourceSearchType type = global::tryAGI.OpenAI.WebSearchActionResourceSearchType.Search)
        {
            this.Type = type;
            this.Query = query;
            this.Queries = queries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionResourceSearch" /> class.
        /// </summary>
        public WebSearchActionResourceSearch()
        {
        }

    }
}