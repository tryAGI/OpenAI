
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `mcp_approval_request`.
    /// </summary>
    public enum BetaMCPApprovalRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        McpApprovalRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPApprovalRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPApprovalRequestType value)
        {
            return value switch
            {
                BetaMCPApprovalRequestType.McpApprovalRequest => "mcp_approval_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPApprovalRequestType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_request" => BetaMCPApprovalRequestType.McpApprovalRequest,
                _ => null,
            };
        }
    }
}