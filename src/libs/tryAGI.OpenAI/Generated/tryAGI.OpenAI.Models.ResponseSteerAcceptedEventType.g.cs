
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.steer.accepted`.
    /// </summary>
    public enum ResponseSteerAcceptedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSteerAccepted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerAcceptedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerAcceptedEventType value)
        {
            return value switch
            {
                ResponseSteerAcceptedEventType.ResponseSteerAccepted => "response.steer.accepted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerAcceptedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.steer.accepted" => ResponseSteerAcceptedEventType.ResponseSteerAccepted,
                _ => null,
            };
        }
    }
}