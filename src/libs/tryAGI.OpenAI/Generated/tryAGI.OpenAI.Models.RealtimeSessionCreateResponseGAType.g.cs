
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of session to create. Always `realtime` for the Realtime API.
    /// </summary>
    public enum RealtimeSessionCreateResponseGAType
    {
        /// <summary>
        /// 
        /// </summary>
        Realtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseGATypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGAType value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGAType.Realtime => "realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGAType? ToEnum(string value)
        {
            return value switch
            {
                "realtime" => RealtimeSessionCreateResponseGAType.Realtime,
                _ => null,
            };
        }
    }
}