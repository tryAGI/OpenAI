
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The object type, must be "realtime.session".<br/>
    /// Example: realtime.session
    /// </summary>
    public enum RealtimeSessionObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionObject value)
        {
            return value switch
            {
                RealtimeSessionObject.RealtimeSession => "realtime.session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.session" => RealtimeSessionObject.RealtimeSession,
                _ => null,
            };
        }
    }
}