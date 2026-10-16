
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decision.event
    /// </summary>
    public enum LiveDecisionEventType
    {
        /// <summary>
        ///
        /// </summary>
        DecisionEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionEventType value)
        {
            return value switch
            {
                LiveDecisionEventType.DecisionEvent => "decision.event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionEventType? ToEnum(string value)
        {
            return value switch
            {
                "decision.event" => LiveDecisionEventType.DecisionEvent,
                _ => null,
            };
        }
    }
}