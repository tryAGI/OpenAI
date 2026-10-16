
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decisions
    /// </summary>
    public enum LiveDecisionsDelegationParam2Type
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionsDelegationParam2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionsDelegationParam2Type value)
        {
            return value switch
            {
                LiveDecisionsDelegationParam2Type.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionsDelegationParam2Type? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LiveDecisionsDelegationParam2Type.Decisions,
                _ => null,
            };
        }
    }
}