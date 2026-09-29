
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.input.computer_use_approval_request_result`.<br/>
    /// Default Value: agent.session.input.computer_use_approval_request_result
    /// </summary>
    public enum SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionInputComputerUseApprovalRequestResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionInputParamAgentSessionInputComputerUseApprovalRequestResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType value)
        {
            return value switch
            {
                SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType.AgentSessionInputComputerUseApprovalRequestResult => "agent.session.input.computer_use_approval_request_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.input.computer_use_approval_request_result" => SessionInputParamAgentSessionInputComputerUseApprovalRequestResultType.AgentSessionInputComputerUseApprovalRequestResult,
                _ => null,
            };
        }
    }
}