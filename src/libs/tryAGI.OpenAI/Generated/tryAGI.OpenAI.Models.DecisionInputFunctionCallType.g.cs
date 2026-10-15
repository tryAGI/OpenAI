
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: function_call
    /// </summary>
    public enum DecisionInputFunctionCallType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputFunctionCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputFunctionCallType value)
        {
            return value switch
            {
                DecisionInputFunctionCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputFunctionCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => DecisionInputFunctionCallType.FunctionCall,
                _ => null,
            };
        }
    }
}