
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.content_part.added`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseContentPartAddedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseContentPartAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseContentPartAddedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseContentPartAddedType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseContentPartAddedType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => RealtimeBetaServerEventResponseContentPartAddedType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}