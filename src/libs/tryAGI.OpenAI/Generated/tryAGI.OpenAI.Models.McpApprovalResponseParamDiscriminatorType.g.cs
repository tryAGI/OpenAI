
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum McpApprovalResponseParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        McpToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalResponseParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalResponseParamDiscriminatorType value)
        {
            return value switch
            {
                McpApprovalResponseParamDiscriminatorType.McpToolCall => "mcp_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalResponseParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_call" => McpApprovalResponseParamDiscriminatorType.McpToolCall,
                _ => null,
            };
        }
    }
}