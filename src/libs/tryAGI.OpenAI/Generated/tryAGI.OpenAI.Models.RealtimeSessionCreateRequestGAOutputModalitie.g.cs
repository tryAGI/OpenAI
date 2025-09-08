
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateRequestGAOutputModalitie
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
    public static class RealtimeSessionCreateRequestGAOutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestGAOutputModalitie value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestGAOutputModalitie.Text => "text",
                RealtimeSessionCreateRequestGAOutputModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestGAOutputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeSessionCreateRequestGAOutputModalitie.Text,
                "audio" => RealtimeSessionCreateRequestGAOutputModalitie.Audio,
                _ => null,
            };
        }
    }
}