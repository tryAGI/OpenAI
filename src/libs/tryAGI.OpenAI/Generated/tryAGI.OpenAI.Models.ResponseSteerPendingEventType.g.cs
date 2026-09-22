
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.steer.pending`.
    /// </summary>
    public enum ResponseSteerPendingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseSteerPending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerPendingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerPendingEventType value)
        {
            return value switch
            {
                ResponseSteerPendingEventType.ResponseSteerPending => "response.steer.pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerPendingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.steer.pending" => ResponseSteerPendingEventType.ResponseSteerPending,
                _ => null,
            };
        }
    }
}