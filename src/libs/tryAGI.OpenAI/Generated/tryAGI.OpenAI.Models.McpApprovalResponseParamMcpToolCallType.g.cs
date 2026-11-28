
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `mcp_tool_call`.<br/>
    /// Default Value: mcp_tool_call
    /// </summary>
    public enum McpApprovalResponseParamMcpToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        McpToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalResponseParamMcpToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalResponseParamMcpToolCallType value)
        {
            return value switch
            {
                McpApprovalResponseParamMcpToolCallType.McpToolCall => "mcp_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalResponseParamMcpToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_call" => McpApprovalResponseParamMcpToolCallType.McpToolCall,
                _ => null,
            };
        }
    }
}