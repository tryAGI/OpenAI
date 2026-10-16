
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decision.item.created
    /// </summary>
    public enum LiveDecisionItemCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionItemCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionItemCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionItemCreatedType value)
        {
            return value switch
            {
                LiveDecisionItemCreatedType.DecisionItemCreated => "decision.item.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionItemCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "decision.item.created" => LiveDecisionItemCreatedType.DecisionItemCreated,
                _ => null,
            };
        }
    }
}