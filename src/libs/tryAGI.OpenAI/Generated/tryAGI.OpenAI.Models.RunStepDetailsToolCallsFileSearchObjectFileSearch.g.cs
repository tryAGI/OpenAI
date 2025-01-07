
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For now, this is always going to be an empty object.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchObjectFileSearch
    {
        /// <summary>
        /// The ranking options for the file search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking_options")]
        public global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject? RankingOptions { get; set; }

        /// <summary>
        /// The results of the file search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchObjectFileSearch" /> class.
        /// </summary>
        /// <param name="rankingOptions">
        /// The ranking options for the file search.
        /// </param>
        /// <param name="results">
        /// The results of the file search.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDetailsToolCallsFileSearchObjectFileSearch(
            global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject? rankingOptions,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? results)
        {
            this.RankingOptions = rankingOptions;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchObjectFileSearch" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFileSearchObjectFileSearch()
        {
        }
    }
}