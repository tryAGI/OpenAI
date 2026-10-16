
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: choice
    /// </summary>
    public enum LiveDecisionChoiceQuestionParamType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionChoiceQuestionParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionChoiceQuestionParamType value)
        {
            return value switch
            {
                LiveDecisionChoiceQuestionParamType.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionChoiceQuestionParamType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => LiveDecisionChoiceQuestionParamType.Choice,
                _ => null,
            };
        }
    }
}