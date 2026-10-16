
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: predicate
    /// </summary>
    public enum LiveDecisionPredicateQuestionParamType
    {
        /// <summary>
        ///
        /// </summary>
        Predicate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionPredicateQuestionParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionPredicateQuestionParamType value)
        {
            return value switch
            {
                LiveDecisionPredicateQuestionParamType.Predicate => "predicate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionPredicateQuestionParamType? ToEnum(string value)
        {
            return value switch
            {
                "predicate" => LiveDecisionPredicateQuestionParamType.Predicate,
                _ => null,
            };
        }
    }
}