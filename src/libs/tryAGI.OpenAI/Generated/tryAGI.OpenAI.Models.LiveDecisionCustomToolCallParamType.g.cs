
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `custom_tool_call`.<br/>
    /// Default Value: custom_tool_call
    /// </summary>
    public enum LiveDecisionCustomToolCallParamType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionCustomToolCallParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionCustomToolCallParamType value)
        {
            return value switch
            {
                LiveDecisionCustomToolCallParamType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionCustomToolCallParamType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => LiveDecisionCustomToolCallParamType.CustomToolCall,
                _ => null,
            };
        }
    }
}