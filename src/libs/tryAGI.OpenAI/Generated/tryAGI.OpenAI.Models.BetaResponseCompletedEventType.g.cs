
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.completed`.
    /// </summary>
    public enum BetaResponseCompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCompletedEventType value)
        {
            return value switch
            {
                BetaResponseCompletedEventType.ResponseCompleted => "response.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.completed" => BetaResponseCompletedEventType.ResponseCompleted,
                _ => null,
            };
        }
    }
}