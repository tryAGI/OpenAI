
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseOutputModalitie
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
    public static class RealtimeSessionCreateResponseOutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseOutputModalitie value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseOutputModalitie.Text => "text",
                RealtimeSessionCreateResponseOutputModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseOutputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeSessionCreateResponseOutputModalitie.Text,
                "audio" => RealtimeSessionCreateResponseOutputModalitie.Audio,
                _ => null,
            };
        }
    }
}