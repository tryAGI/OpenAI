
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The object type. Always `realtime.session`.
    /// </summary>
    public enum RealtimeSessionCreateResponseGAObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseGAObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGAObject value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGAObject.RealtimeSession => "realtime.session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGAObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.session" => RealtimeSessionCreateResponseGAObject.RealtimeSession,
                _ => null,
            };
        }
    }
}