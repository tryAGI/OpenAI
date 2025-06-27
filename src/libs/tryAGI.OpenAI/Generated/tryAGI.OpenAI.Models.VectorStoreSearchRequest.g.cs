
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreSearchRequest
    {
        /// <summary>
        /// A filter to apply based on file attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>? Filters { get; set; }

        /// <summary>
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// A query string for a search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>> Query { get; set; }

        /// <summary>
        /// Ranking options for search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking_options")]
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// Whether to rewrite the natural language query for vector search.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewrite_query")]
        public bool? RewriteQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchRequest" /> class.
        /// </summary>
        /// <param name="filters">
        /// A filter to apply based on file attributes.
        /// </param>
        /// <param name="maxNumResults">
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="query">
        /// A query string for a search
        /// </param>
        /// <param name="rankingOptions">
        /// Ranking options for search.
        /// </param>
        /// <param name="rewriteQuery">
        /// Whether to rewrite the natural language query for vector search.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreSearchRequest(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>> query,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>? filters,
            int? maxNumResults,
            global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptions? rankingOptions,
            bool? rewriteQuery)
        {
            this.Query = query;
            this.Filters = filters;
            this.MaxNumResults = maxNumResults;
            this.RankingOptions = rankingOptions;
            this.RewriteQuery = rewriteQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchRequest" /> class.
        /// </summary>
        public VectorStoreSearchRequest()
        {
        }
    }
}