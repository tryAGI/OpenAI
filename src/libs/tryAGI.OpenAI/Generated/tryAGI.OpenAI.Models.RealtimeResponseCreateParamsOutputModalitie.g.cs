
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseCreateParamsOutputModalitie
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
    public static class RealtimeResponseCreateParamsOutputModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateParamsOutputModalitie value)
        {
            return value switch
            {
                RealtimeResponseCreateParamsOutputModalitie.Text => "text",
                RealtimeResponseCreateParamsOutputModalitie.Audio => "audio",
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
                "text" => RealtimeResponseCreateParamsOutputModalitie.Text,
                "audio" => RealtimeResponseCreateParamsOutputModalitie.Audio,
                _ => null,
            };
        }
    }
}