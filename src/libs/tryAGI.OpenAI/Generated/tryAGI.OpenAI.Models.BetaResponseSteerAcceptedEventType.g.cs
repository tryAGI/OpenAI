
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.steer.accepted`.
    /// </summary>
    public enum BetaResponseSteerAcceptedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSteerAccepted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerAcceptedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerAcceptedEventType value)
        {
            return value switch
            {
                BetaResponseSteerAcceptedEventType.ResponseSteerAccepted => "response.steer.accepted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerAcceptedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.steer.accepted" => BetaResponseSteerAcceptedEventType.ResponseSteerAccepted,
                _ => null,
            };
        }
    }
}