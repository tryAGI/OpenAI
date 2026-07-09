
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `mcp_approval_response`.
    /// </summary>
    public enum BetaMCPApprovalResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        McpApprovalResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPApprovalResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPApprovalResponseType value)
        {
            return value switch
            {
                BetaMCPApprovalResponseType.McpApprovalResponse => "mcp_approval_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPApprovalResponseType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_response" => BetaMCPApprovalResponseType.McpApprovalResponse,
                _ => null,
            };
        }
    }
}