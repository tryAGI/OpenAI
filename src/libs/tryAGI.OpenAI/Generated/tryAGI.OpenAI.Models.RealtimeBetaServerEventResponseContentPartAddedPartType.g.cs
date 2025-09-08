
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type ("text", "audio").
    /// </summary>
    public enum RealtimeBetaServerEventResponseContentPartAddedPartType
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
    public static class RealtimeBetaServerEventResponseContentPartAddedPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseContentPartAddedPartType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseContentPartAddedPartType.Text => "text",
                RealtimeBetaServerEventResponseContentPartAddedPartType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseContentPartAddedPartType? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeBetaServerEventResponseContentPartAddedPartType.Text,
                "audio" => RealtimeBetaServerEventResponseContentPartAddedPartType.Audio,
                _ => null,
            };
        }
    }
}