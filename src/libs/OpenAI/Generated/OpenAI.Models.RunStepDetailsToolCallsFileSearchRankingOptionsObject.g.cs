
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The ranking options for the file search.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchRankingOptionsObject
    {
        /// <summary>
        /// The ranker used for the file search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunStepDetailsToolCallsFileSearchRankingOptionsObjectRankerJsonConverter))]
        public global::OpenAI.RunStepDetailsToolCallsFileSearchRankingOptionsObjectRanker Ranker { get; set; }

        /// <summary>
        /// The score threshold for the file search. All values must be a floating point number between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}