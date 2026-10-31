
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputMessageType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageType value)
        {
            return value switch
            {
                RealtimeResponseInputMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => RealtimeResponseInputMessageType.Message,
                _ => null,
            };
        }
    }
}