
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type ("text", "audio").
    /// </summary>
    public enum RealtimeBetaServerEventResponseContentPartDonePartType
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
    public static class RealtimeBetaServerEventResponseContentPartDonePartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseContentPartDonePartType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseContentPartDonePartType.Audio => "audio",
                RealtimeBetaServerEventResponseContentPartDonePartType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseContentPartDonePartType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RealtimeBetaServerEventResponseContentPartDonePartType.Audio,
                "text" => RealtimeBetaServerEventResponseContentPartDonePartType.Text,
                _ => null,
            };
        }
    }
}