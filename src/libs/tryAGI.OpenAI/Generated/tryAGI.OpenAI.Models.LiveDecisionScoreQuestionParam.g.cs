
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionScoreQuestionParam
    {
        /// <summary>
        /// Default Value: score
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamType.Score</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionScoreQuestionParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamType.Score;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item3>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item3>> Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("levels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionScoreLevelParam> Levels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionScoreQuestionParam" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="levels"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: score
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionScoreQuestionParam(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InstructionsVariant2Item3>> instructions,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LiveDecisionScoreLevelParam> levels,
            string? name,
            global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamType type = global::tryAGI.OpenAI.LiveDecisionScoreQuestionParamType.Score)
        {
            this.Type = type;
            this.Name = name;
            this.Instructions = instructions;
            this.Levels = levels ?? throw new global::System.ArgumentNullException(nameof(levels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionScoreQuestionParam" /> class.
        /// </summary>
        public LiveDecisionScoreQuestionParam()
        {
        }

    }
}