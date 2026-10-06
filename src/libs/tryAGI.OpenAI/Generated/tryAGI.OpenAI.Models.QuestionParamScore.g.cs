
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QuestionParamScore
    {
        /// <summary>
        /// The type of the object. Always `score`.<br/>
        /// Default Value: score
        /// </summary>
        /// <default>global::tryAGI.OpenAI.QuestionParamScoreType.Score</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.QuestionParamScoreTypeJsonConverter))]
        public global::tryAGI.OpenAI.QuestionParamScoreType Type { get; set; } = global::tryAGI.OpenAI.QuestionParamScoreType.Score;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("levels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreLevelParam> Levels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionParamScore" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="levels"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the object. Always `score`.<br/>
        /// Default Value: score
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuestionParamScore(
            string instructions,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ScoreLevelParam> levels,
            string? name,
            global::tryAGI.OpenAI.QuestionParamScoreType type = global::tryAGI.OpenAI.QuestionParamScoreType.Score)
        {
            this.Type = type;
            this.Name = name;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Levels = levels ?? throw new global::System.ArgumentNullException(nameof(levels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionParamScore" /> class.
        /// </summary>
        public QuestionParamScore()
        {
        }

    }
}