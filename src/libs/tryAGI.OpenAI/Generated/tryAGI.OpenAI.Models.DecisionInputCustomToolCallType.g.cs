
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: custom_tool_call
    /// </summary>
    public enum DecisionInputCustomToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputCustomToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputCustomToolCallType value)
        {
            return value switch
            {
                DecisionInputCustomToolCallType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputCustomToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => DecisionInputCustomToolCallType.CustomToolCall,
                _ => null,
            };
        }
    }
}