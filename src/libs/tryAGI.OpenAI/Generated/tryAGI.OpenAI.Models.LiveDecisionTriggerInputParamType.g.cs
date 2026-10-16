
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decisions
    /// </summary>
    public enum LiveDecisionTriggerInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionTriggerInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionTriggerInputParamType value)
        {
            return value switch
            {
                LiveDecisionTriggerInputParamType.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionTriggerInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LiveDecisionTriggerInputParamType.Decisions,
                _ => null,
            };
        }
    }
}