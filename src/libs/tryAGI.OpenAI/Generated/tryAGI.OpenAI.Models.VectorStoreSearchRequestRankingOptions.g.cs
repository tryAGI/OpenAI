
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Ranking options for search.
    /// </summary>
    public sealed partial class VectorStoreSearchRequestRankingOptions
    {
        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchRequestRankingOptionsRankerJsonConverter))]
        public global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker? Ranker { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchRequestRankingOptions" /> class.
        /// </summary>
        /// <param name="ranker">
        /// Default Value: auto
        /// </param>
        /// <param name="scoreThreshold">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreSearchRequestRankingOptions(
            global::tryAGI.OpenAI.VectorStoreSearchRequestRankingOptionsRanker? ranker,
            double? scoreThreshold)
        {
            this.Ranker = ranker;
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchRequestRankingOptions" /> class.
        /// </summary>
        public VectorStoreSearchRequestRankingOptions()
        {
        }
    }
}