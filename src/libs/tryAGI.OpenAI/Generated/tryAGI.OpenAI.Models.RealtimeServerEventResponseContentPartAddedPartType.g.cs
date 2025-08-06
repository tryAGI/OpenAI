
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type ("text", "audio").
    /// </summary>
    public enum RealtimeServerEventResponseContentPartAddedPartType
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
    public static class RealtimeServerEventResponseContentPartAddedPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseContentPartAddedPartType value)
        {
            return value switch
            {
                RealtimeServerEventResponseContentPartAddedPartType.Text => "text",
                RealtimeServerEventResponseContentPartAddedPartType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseContentPartAddedPartType? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeServerEventResponseContentPartAddedPartType.Text,
                "audio" => RealtimeServerEventResponseContentPartAddedPartType.Audio,
                _ => null,
            };
        }
    }
}