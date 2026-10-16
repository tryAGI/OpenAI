
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decision.create
    /// </summary>
    public enum LiveDecisionCreateParamType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionCreateParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionCreateParamType value)
        {
            return value switch
            {
                LiveDecisionCreateParamType.DecisionCreate => "decision.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionCreateParamType? ToEnum(string value)
        {
            return value switch
            {
                "decision.create" => LiveDecisionCreateParamType.DecisionCreate,
                _ => null,
            };
        }
    }
}