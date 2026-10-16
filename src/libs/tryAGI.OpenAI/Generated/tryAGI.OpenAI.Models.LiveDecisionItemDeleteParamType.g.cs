
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decision.item.delete
    /// </summary>
    public enum LiveDecisionItemDeleteParamType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionItemDelete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionItemDeleteParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionItemDeleteParamType value)
        {
            return value switch
            {
                LiveDecisionItemDeleteParamType.DecisionItemDelete => "decision.item.delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionItemDeleteParamType? ToEnum(string value)
        {
            return value switch
            {
                "decision.item.delete" => LiveDecisionItemDeleteParamType.DecisionItemDelete,
                _ => null,
            };
        }
    }
}