
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.steer.failed`.
    /// </summary>
    public enum BetaResponseSteerFailedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSteerFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerFailedEventType value)
        {
            return value switch
            {
                BetaResponseSteerFailedEventType.ResponseSteerFailed => "response.steer.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.steer.failed" => BetaResponseSteerFailedEventType.ResponseSteerFailed,
                _ => null,
            };
        }
    }
}