
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.content_part.done".<br/>
    /// Example: response.content_part.done
    /// </summary>
    public enum RealtimeResponseContentPartDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseContentPartDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseContentPartDoneType value)
        {
            return value switch
            {
                RealtimeResponseContentPartDoneType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseContentPartDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => RealtimeResponseContentPartDoneType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}