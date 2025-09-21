
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `mcp_call`.
    /// </summary>
    public enum RealtimeMCPToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        McpCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeMCPToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeMCPToolCallType value)
        {
            return value switch
            {
                RealtimeMCPToolCallType.McpCall => "mcp_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeMCPToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_call" => RealtimeMCPToolCallType.McpCall,
                _ => null,
            };
        }
    }
}