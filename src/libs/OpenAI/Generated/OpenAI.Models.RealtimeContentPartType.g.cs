
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The content type.<br/>
    /// Example: text
    /// </summary>
    public enum RealtimeContentPartType
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
    public static class RealtimeContentPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeContentPartType value)
        {
            return value switch
            {
                RealtimeContentPartType.Text => "text",
                RealtimeContentPartType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeContentPartType? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeContentPartType.Text,
                "audio" => RealtimeContentPartType.Audio,
                _ => null,
            };
        }
    }
}