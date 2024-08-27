
#nullable enable

namespace OpenAI
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
        public global::OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObject? RankingOptions { get; set; }

        /// <summary>
        /// The results of the file search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::OpenAI.RunStepDetailsToolCallsFileSearchResultObject>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}