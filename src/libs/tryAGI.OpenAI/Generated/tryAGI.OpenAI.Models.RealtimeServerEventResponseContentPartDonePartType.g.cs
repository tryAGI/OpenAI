
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type ("text", "audio").
    /// </summary>
    public enum RealtimeServerEventResponseContentPartDonePartType
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
    public static class RealtimeServerEventResponseContentPartDonePartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseContentPartDonePartType value)
        {
            return value switch
            {
                RealtimeServerEventResponseContentPartDonePartType.Text => "text",
                RealtimeServerEventResponseContentPartDonePartType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseContentPartDonePartType? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeServerEventResponseContentPartDonePartType.Text,
                "audio" => RealtimeServerEventResponseContentPartDonePartType.Audio,
                _ => null,
            };
        }
    }
}