
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decisions
    /// </summary>
    public enum LiveDecisionsDelegationUpdateParamType
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionsDelegationUpdateParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionsDelegationUpdateParamType value)
        {
            return value switch
            {
                LiveDecisionsDelegationUpdateParamType.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionsDelegationUpdateParamType? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LiveDecisionsDelegationUpdateParamType.Decisions,
                _ => null,
            };
        }
    }
}