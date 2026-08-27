
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the custom tool call. Always `custom_tool_call`.
    /// </summary>
    public enum BetaCustomToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCustomToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCustomToolCallType value)
        {
            return value switch
            {
                BetaCustomToolCallType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCustomToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => BetaCustomToolCallType.CustomToolCall,
                _ => null,
            };
        }
    }
}