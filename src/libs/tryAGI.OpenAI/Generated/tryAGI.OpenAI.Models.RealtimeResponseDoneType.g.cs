
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "response.done".<br/>
    /// Example: response.done
    /// </summary>
    public enum RealtimeResponseDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseDoneType value)
        {
            return value switch
            {
                RealtimeResponseDoneType.ResponseDone => "response.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.done" => RealtimeResponseDoneType.ResponseDone,
                _ => null,
            };
        }
    }
}