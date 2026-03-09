
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankingOptions
    {
        /// <summary>
        /// The ranker to use for the file search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RankerVersionTypeJsonConverter))]
        public global::tryAGI.OpenAI.RankerVersionType? Ranker { get; set; }

        /// <summary>
        /// The score threshold for the file search, a number between 0 and 1. Numbers closer to 1 will attempt to return only the most relevant results, but may return fewer results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Weights that control how reciprocal rank fusion balances semantic embedding matches versus sparse keyword matches when hybrid search is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hybrid_search")]
        public global::tryAGI.OpenAI.HybridSearchOptions? HybridSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingOptions" /> class.
        /// </summary>
        /// <param name="ranker">
        /// The ranker to use for the file search.
        /// </param>
        /// <param name="scoreThreshold">
        /// The score threshold for the file search, a number between 0 and 1. Numbers closer to 1 will attempt to return only the most relevant results, but may return fewer results.
        /// </param>
        /// <param name="hybridSearch">
        /// Weights that control how reciprocal rank fusion balances semantic embedding matches versus sparse keyword matches when hybrid search is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankingOptions(
            global::tryAGI.OpenAI.RankerVersionType? ranker,
            double? scoreThreshold,
            global::tryAGI.OpenAI.HybridSearchOptions? hybridSearch)
        {
            this.Ranker = ranker;
            this.ScoreThreshold = scoreThreshold;
            this.HybridSearch = hybridSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingOptions" /> class.
        /// </summary>
        public RankingOptions()
        {
        }
    }
}