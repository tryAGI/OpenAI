
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.queued'.
    /// </summary>
    public enum BetaResponseQueuedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseQueued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseQueuedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseQueuedEventType value)
        {
            return value switch
            {
                BetaResponseQueuedEventType.ResponseQueued => "response.queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseQueuedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.queued" => BetaResponseQueuedEventType.ResponseQueued,
                _ => null,
            };
        }
    }
}