
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum McpApprovalRequestResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        McpToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalRequestResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalRequestResourceDiscriminatorType value)
        {
            return value switch
            {
                McpApprovalRequestResourceDiscriminatorType.McpToolCall => "mcp_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalRequestResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_call" => McpApprovalRequestResourceDiscriminatorType.McpToolCall,
                _ => null,
            };
        }
    }
}