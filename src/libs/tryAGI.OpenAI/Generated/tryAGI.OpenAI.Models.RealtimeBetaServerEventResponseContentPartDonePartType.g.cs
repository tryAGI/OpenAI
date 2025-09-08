
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
        Text,
        /// <summary>
        /// 
        /// </summary>
        Audio,
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
                RealtimeBetaServerEventResponseContentPartDonePartType.Text => "text",
                RealtimeBetaServerEventResponseContentPartDonePartType.Audio => "audio",
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
                "text" => RealtimeBetaServerEventResponseContentPartDonePartType.Text,
                "audio" => RealtimeBetaServerEventResponseContentPartDonePartType.Audio,
                _ => null,
            };
        }
    }
}