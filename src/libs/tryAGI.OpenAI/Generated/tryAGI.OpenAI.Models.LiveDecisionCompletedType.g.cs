
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decision.completed
    /// </summary>
    public enum LiveDecisionCompletedType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionCompletedType value)
        {
            return value switch
            {
                LiveDecisionCompletedType.DecisionCompleted => "decision.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "decision.completed" => LiveDecisionCompletedType.DecisionCompleted,
                _ => null,
            };
        }
    }
}