
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.text.done".<br/>
    /// Example: response.text.done
    /// </summary>
    public enum RealtimeResponseTextDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseTextDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseTextDoneType value)
        {
            return value switch
            {
                RealtimeResponseTextDoneType.ResponseTextDone => "response.text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseTextDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.text.done" => RealtimeResponseTextDoneType.ResponseTextDone,
                _ => null,
            };
        }
    }
}