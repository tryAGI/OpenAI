
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
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Text,
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
                RealtimeSessionCreateRequestGAOutputModalitie.Audio => "audio",
                RealtimeSessionCreateRequestGAOutputModalitie.Text => "text",
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
                "audio" => RealtimeSessionCreateRequestGAOutputModalitie.Audio,
                "text" => RealtimeSessionCreateRequestGAOutputModalitie.Text,
                _ => null,
            };
        }
    }
}