
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the function tool call. Always `function_call`.
    /// </summary>
    public enum FunctionToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionToolCallType value)
        {
            return value switch
            {
                FunctionToolCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => FunctionToolCallType.FunctionCall,
                _ => null,
            };
        }
    }
}