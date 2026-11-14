
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `mcp_approval_request`.<br/>
    /// Default Value: mcp_approval_request
    /// </summary>
    public enum SessionRequiredActionResourceMcpApprovalRequestType
    {
        /// <summary>
        ///
        /// </summary>
        McpApprovalRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionRequiredActionResourceMcpApprovalRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionRequiredActionResourceMcpApprovalRequestType value)
        {
            return value switch
            {
                SessionRequiredActionResourceMcpApprovalRequestType.McpApprovalRequest => "mcp_approval_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionRequiredActionResourceMcpApprovalRequestType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_request" => SessionRequiredActionResourceMcpApprovalRequestType.McpApprovalRequest,
                _ => null,
            };
        }
    }
}