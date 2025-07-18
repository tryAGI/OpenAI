
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `mcp_approval_response`.
    /// </summary>
    public enum MCPApprovalResponseResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        McpApprovalResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPApprovalResponseResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPApprovalResponseResourceType value)
        {
            return value switch
            {
                MCPApprovalResponseResourceType.McpApprovalResponse => "mcp_approval_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPApprovalResponseResourceType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_response" => MCPApprovalResponseResourceType.McpApprovalResponse,
                _ => null,
            };
        }
    }
}