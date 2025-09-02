
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateRequestOutputModalitie
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestOutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestOutputModalitie value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestOutputModalitie.Text => "text",
                RealtimeSessionCreateRequestOutputModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestOutputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeSessionCreateRequestOutputModalitie.Text,
                "audio" => RealtimeSessionCreateRequestOutputModalitie.Audio,
                _ => null,
            };
        }
    }
}