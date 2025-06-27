
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Action type "search" - Performs a web search query.
    /// </summary>
    public sealed partial class WebSearchActionSearch
    {
        /// <summary>
        /// The search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The action type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionSearchType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionSearch" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query.
        /// </param>
        /// <param name="type">
        /// The action type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionSearch(
            string query,
            global::tryAGI.OpenAI.WebSearchActionSearchType type)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionSearch" /> class.
        /// </summary>
        public WebSearchActionSearch()
        {
        }
    }
}