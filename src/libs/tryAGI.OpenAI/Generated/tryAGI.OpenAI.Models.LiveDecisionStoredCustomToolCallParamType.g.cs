
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `custom_tool_call`.<br/>
    /// Default Value: custom_tool_call
    /// </summary>
    public enum LiveDecisionStoredCustomToolCallParamType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredCustomToolCallParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredCustomToolCallParamType value)
        {
            return value switch
            {
                LiveDecisionStoredCustomToolCallParamType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredCustomToolCallParamType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => LiveDecisionStoredCustomToolCallParamType.CustomToolCall,
                _ => null,
            };
        }
    }
}