
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.steer`.
    /// </summary>
    public enum BetaResponseSteerEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSteer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerEventType value)
        {
            return value switch
            {
                BetaResponseSteerEventType.ResponseSteer => "response.steer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.steer" => BetaResponseSteerEventType.ResponseSteer,
                _ => null,
            };
        }
    }
}