
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decision.item.create
    /// </summary>
    public enum LiveDecisionItemCreateParamType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionItemCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionItemCreateParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionItemCreateParamType value)
        {
            return value switch
            {
                LiveDecisionItemCreateParamType.DecisionItemCreate => "decision.item.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionItemCreateParamType? ToEnum(string value)
        {
            return value switch
            {
                "decision.item.create" => LiveDecisionItemCreateParamType.DecisionItemCreate,
                _ => null,
            };
        }
    }
}