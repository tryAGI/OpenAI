
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: score
    /// </summary>
    public enum LiveDecisionScoreQuestionParamType
    {
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionScoreQuestionParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionScoreQuestionParamType value)
        {
            return value switch
            {
                LiveDecisionScoreQuestionParamType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionScoreQuestionParamType? ToEnum(string value)
        {
            return value switch
            {
                "score" => LiveDecisionScoreQuestionParamType.Score,
                _ => null,
            };
        }
    }
}