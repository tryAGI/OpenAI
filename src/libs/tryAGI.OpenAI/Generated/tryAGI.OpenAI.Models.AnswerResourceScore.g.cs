
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerResourceScore
    {
        /// <summary>
        /// The type of the object. Always `score`.<br/>
        /// Default Value: score
        /// </summary>
        /// <default>global::tryAGI.OpenAI.AnswerResourceScoreType.Score</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnswerResourceScoreTypeJsonConverter))]
        public global::tryAGI.OpenAI.AnswerResourceScoreType Type { get; set; } = global::tryAGI.OpenAI.AnswerResourceScoreType.Score;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreProbabilityResource> Probabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResourceScore" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="probabilities"></param>
        /// <param name="confidence"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the object. Always `score`.<br/>
        /// Default Value: score
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerResourceScore(
            double score,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreProbabilityResource> probabilities,
            double confidence,
            string? name,
            global::tryAGI.OpenAI.AnswerResourceScoreType type = global::tryAGI.OpenAI.AnswerResourceScoreType.Score)
        {
            this.Type = type;
            this.Name = name;
            this.Score = score;
            this.Probabilities = probabilities ?? throw new global::System.ArgumentNullException(nameof(probabilities));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResourceScore" /> class.
        /// </summary>
        public AnswerResourceScore()
        {
        }

    }
}