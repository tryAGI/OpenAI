
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseCreateResponseModalitie
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
    public static class RealtimeResponseCreateResponseModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateResponseModalitie value)
        {
            return value switch
            {
                RealtimeResponseCreateResponseModalitie.Text => "text",
                RealtimeResponseCreateResponseModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateResponseModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeResponseCreateResponseModalitie.Text,
                "audio" => RealtimeResponseCreateResponseModalitie.Audio,
                _ => null,
            };
        }
    }
}