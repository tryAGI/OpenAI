
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionRequiredActionResourceDiscriminatorType
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
    public static class SessionRequiredActionResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionRequiredActionResourceDiscriminatorType value)
        {
            return value switch
            {
                SessionRequiredActionResourceDiscriminatorType.ComputerUseApprovalRequest => "computer_use_approval_request",
                SessionRequiredActionResourceDiscriminatorType.EnvironmentConnection => "environment_connection",
                SessionRequiredActionResourceDiscriminatorType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionRequiredActionResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_approval_request" => SessionRequiredActionResourceDiscriminatorType.ComputerUseApprovalRequest,
                "environment_connection" => SessionRequiredActionResourceDiscriminatorType.EnvironmentConnection,
                "function_call" => SessionRequiredActionResourceDiscriminatorType.FunctionCall,
                _ => null,
            };
        }
    }
}