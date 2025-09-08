
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.content_part.done`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseContentPartDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseContentPartDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseContentPartDoneType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseContentPartDoneType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseContentPartDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => RealtimeBetaServerEventResponseContentPartDoneType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}