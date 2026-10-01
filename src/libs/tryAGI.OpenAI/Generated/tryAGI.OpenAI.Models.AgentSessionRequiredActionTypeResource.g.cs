
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSessionRequiredActionTypeResource
    {
        /// <summary>
        ///
        /// </summary>
        ComputerUseApprovalRequest,
        /// <summary>
        ///
        /// </summary>
        EnvironmentConnection,
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionRequiredActionTypeResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionRequiredActionTypeResource value)
        {
            return value switch
            {
                AgentSessionRequiredActionTypeResource.ComputerUseApprovalRequest => "computer_use_approval_request",
                AgentSessionRequiredActionTypeResource.EnvironmentConnection => "environment_connection",
                AgentSessionRequiredActionTypeResource.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionRequiredActionTypeResource? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_approval_request" => AgentSessionRequiredActionTypeResource.ComputerUseApprovalRequest,
                "environment_connection" => AgentSessionRequiredActionTypeResource.EnvironmentConnection,
                "function_call" => AgentSessionRequiredActionTypeResource.FunctionCall,
                _ => null,
            };
        }
    }
}