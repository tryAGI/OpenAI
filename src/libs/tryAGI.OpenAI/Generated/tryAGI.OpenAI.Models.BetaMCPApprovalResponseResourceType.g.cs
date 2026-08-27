
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `mcp_approval_response`.
    /// </summary>
    public enum BetaMCPApprovalResponseResourceType
    {
        /// <summary>
        ///
        /// </summary>
        McpApprovalResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPApprovalResponseResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPApprovalResponseResourceType value)
        {
            return value switch
            {
                BetaMCPApprovalResponseResourceType.McpApprovalResponse => "mcp_approval_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPApprovalResponseResourceType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_response" => BetaMCPApprovalResponseResourceType.McpApprovalResponse,
                _ => null,
            };
        }
    }
}