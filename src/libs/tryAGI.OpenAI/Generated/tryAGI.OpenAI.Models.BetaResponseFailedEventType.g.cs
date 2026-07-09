
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.failed`.
    /// </summary>
    public enum BetaResponseFailedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseFailedEventType value)
        {
            return value switch
            {
                BetaResponseFailedEventType.ResponseFailed => "response.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.failed" => BetaResponseFailedEventType.ResponseFailed,
                _ => null,
            };
        }
    }
}