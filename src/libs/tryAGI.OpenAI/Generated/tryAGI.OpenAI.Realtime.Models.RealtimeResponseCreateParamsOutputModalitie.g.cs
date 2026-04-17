
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseCreateParamsOutputModalitie
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
    public static class RealtimeResponseCreateParamsOutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateParamsOutputModalitie value)
        {
            return value switch
            {
                RealtimeResponseCreateParamsOutputModalitie.Audio => "audio",
                RealtimeResponseCreateParamsOutputModalitie.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateParamsOutputModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RealtimeResponseCreateParamsOutputModalitie.Audio,
                "text" => RealtimeResponseCreateParamsOutputModalitie.Text,
                _ => null,
            };
        }
    }
}