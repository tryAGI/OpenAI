
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "error".<br/>
    /// Example: error
    /// </summary>
    public enum RealtimeErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeErrorType value)
        {
            return value switch
            {
                RealtimeErrorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeErrorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => RealtimeErrorType.Error,
                _ => null,
            };
        }
    }
}