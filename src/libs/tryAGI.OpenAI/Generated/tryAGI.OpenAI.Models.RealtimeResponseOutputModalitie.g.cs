
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseOutputModalitie
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
    public static class RealtimeResponseOutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseOutputModalitie value)
        {
            return value switch
            {
                RealtimeResponseOutputModalitie.Text => "text",
                RealtimeResponseOutputModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseOutputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeResponseOutputModalitie.Text,
                "audio" => RealtimeResponseOutputModalitie.Audio,
                _ => null,
            };
        }
    }
}