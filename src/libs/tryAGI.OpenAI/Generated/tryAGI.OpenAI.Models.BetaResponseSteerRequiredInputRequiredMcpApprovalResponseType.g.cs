
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType
    {
        /// <summary>
        ///
        /// </summary>
        McpApprovalResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerRequiredInputRequiredMcpApprovalResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType value)
        {
            return value switch
            {
                BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType.McpApprovalResponse => "mcp_approval_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_response" => BetaResponseSteerRequiredInputRequiredMcpApprovalResponseType.McpApprovalResponse,
                _ => null,
            };
        }
    }
}