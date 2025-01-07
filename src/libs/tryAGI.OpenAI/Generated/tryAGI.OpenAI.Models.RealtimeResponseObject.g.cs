
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, must be "realtime.response".<br/>
    /// Example: realtime.response
    /// </summary>
    public enum RealtimeResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseObject value)
        {
            return value switch
            {
                RealtimeResponseObject.RealtimeResponse => "realtime.response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.response" => RealtimeResponseObject.RealtimeResponse,
                _ => null,
            };
        }
    }
}