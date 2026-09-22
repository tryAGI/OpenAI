
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.steer`.
    /// </summary>
    public enum ResponseSteerEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSteer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerEventType value)
        {
            return value switch
            {
                ResponseSteerEventType.ResponseSteer => "response.steer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.steer" => ResponseSteerEventType.ResponseSteer,
                _ => null,
            };
        }
    }
}