
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputFunctionCallType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputFunctionCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputFunctionCallType value)
        {
            return value switch
            {
                RealtimeResponseInputFunctionCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputFunctionCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => RealtimeResponseInputFunctionCallType.FunctionCall,
                _ => null,
            };
        }
    }
}