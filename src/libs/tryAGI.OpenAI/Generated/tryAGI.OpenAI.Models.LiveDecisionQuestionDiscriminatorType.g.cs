
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionQuestionDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
        /// <summary>
        ///
        /// </summary>
        Predicate,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionQuestionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionQuestionDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionQuestionDiscriminatorType.Choice => "choice",
                LiveDecisionQuestionDiscriminatorType.Predicate => "predicate",
                LiveDecisionQuestionDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionQuestionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => LiveDecisionQuestionDiscriminatorType.Choice,
                "predicate" => LiveDecisionQuestionDiscriminatorType.Predicate,
                "score" => LiveDecisionQuestionDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}