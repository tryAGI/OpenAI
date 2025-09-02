
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of session to create. Always `realtime` for the Realtime API.
    /// </summary>
    public enum RealtimeSessionCreateRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Realtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestType value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestType.Realtime => "realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "realtime" => RealtimeSessionCreateRequestType.Realtime,
                _ => null,
            };
        }
    }
}