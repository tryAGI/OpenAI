
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, must be `realtime.response`.
    /// </summary>
    public enum RealtimeBetaResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseObject value)
        {
            return value switch
            {
                RealtimeBetaResponseObject.RealtimeResponse => "realtime.response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.response" => RealtimeBetaResponseObject.RealtimeResponse,
                _ => null,
            };
        }
    }
}