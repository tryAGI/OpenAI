
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the custom tool call. Always `custom_tool_call`.
    /// </summary>
    public enum CustomToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolCallType value)
        {
            return value switch
            {
                CustomToolCallType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => CustomToolCallType.CustomToolCall,
                _ => null,
            };
        }
    }
}