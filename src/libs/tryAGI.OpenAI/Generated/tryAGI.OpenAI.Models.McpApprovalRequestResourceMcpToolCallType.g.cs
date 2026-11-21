
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `mcp_tool_call`.<br/>
    /// Default Value: mcp_tool_call
    /// </summary>
    public enum McpApprovalRequestResourceMcpToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        McpToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalRequestResourceMcpToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalRequestResourceMcpToolCallType value)
        {
            return value switch
            {
                McpApprovalRequestResourceMcpToolCallType.McpToolCall => "mcp_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalRequestResourceMcpToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_call" => McpApprovalRequestResourceMcpToolCallType.McpToolCall,
                _ => null,
            };
        }
    }
}