
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseGAOutputModalitie
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
    public static class RealtimeSessionCreateResponseGAOutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGAOutputModalitie value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGAOutputModalitie.Audio => "audio",
                RealtimeSessionCreateResponseGAOutputModalitie.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGAOutputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RealtimeSessionCreateResponseGAOutputModalitie.Audio,
                "text" => RealtimeSessionCreateResponseGAOutputModalitie.Text,
                _ => null,
            };
        }
    }
}