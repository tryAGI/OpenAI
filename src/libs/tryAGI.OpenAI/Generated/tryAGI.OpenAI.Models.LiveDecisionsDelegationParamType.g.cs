
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decisions
    /// </summary>
    public enum LiveDecisionsDelegationParamType
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionsDelegationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionsDelegationParamType value)
        {
            return value switch
            {
                LiveDecisionsDelegationParamType.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionsDelegationParamType? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LiveDecisionsDelegationParamType.Decisions,
                _ => null,
            };
        }
    }
}