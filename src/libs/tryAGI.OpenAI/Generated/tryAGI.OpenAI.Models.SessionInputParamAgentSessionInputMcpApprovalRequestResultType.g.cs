
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.input.mcp_approval_request_result`.<br/>
    /// Default Value: agent.session.input.mcp_approval_request_result
    /// </summary>
    public enum SessionInputParamAgentSessionInputMcpApprovalRequestResultType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionInputMcpApprovalRequestResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionInputParamAgentSessionInputMcpApprovalRequestResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionInputParamAgentSessionInputMcpApprovalRequestResultType value)
        {
            return value switch
            {
                SessionInputParamAgentSessionInputMcpApprovalRequestResultType.AgentSessionInputMcpApprovalRequestResult => "agent.session.input.mcp_approval_request_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionInputParamAgentSessionInputMcpApprovalRequestResultType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.input.mcp_approval_request_result" => SessionInputParamAgentSessionInputMcpApprovalRequestResultType.AgentSessionInputMcpApprovalRequestResult,
                _ => null,
            };
        }
    }
}