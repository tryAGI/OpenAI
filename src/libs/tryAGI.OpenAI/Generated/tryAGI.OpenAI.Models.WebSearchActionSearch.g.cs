
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Action type "search" - Performs a web search query.
    /// </summary>
    public sealed partial class WebSearchActionSearch
    {
        /// <summary>
        /// The action type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchTypeJsonConverter))]
        public global::tryAGI.OpenAI.WebSearchActionSearchType Type { get; set; }

        /// <summary>
        /// The search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Query { get; set; }

        /// <summary>
        /// The search queries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

        /// <summary>
        /// The sources used in the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionSearch" /> class.
        /// </summary>
        /// <param name="type">
        /// The action type.
        /// </param>
        /// <param name="queries">
        /// The search queries.
        /// </param>
        /// <param name="sources">
        /// The sources used in the search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchActionSearch(
            global::tryAGI.OpenAI.WebSearchActionSearchType type,
            global::System.Collections.Generic.IList<string>? queries,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>? sources)
        {
            this.Type = type;
            this.Queries = queries;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchActionSearch" /> class.
        /// </summary>
        public WebSearchActionSearch()
        {
        }

    }
}