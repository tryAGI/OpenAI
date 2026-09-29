
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `computer_use_approval_request`.<br/>
    /// Default Value: computer_use_approval_request
    /// </summary>
    public enum SessionRequiredActionResourceComputerUseApprovalRequestType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerUseApprovalRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionRequiredActionResourceComputerUseApprovalRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionRequiredActionResourceComputerUseApprovalRequestType value)
        {
            return value switch
            {
                SessionRequiredActionResourceComputerUseApprovalRequestType.ComputerUseApprovalRequest => "computer_use_approval_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionRequiredActionResourceComputerUseApprovalRequestType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_approval_request" => SessionRequiredActionResourceComputerUseApprovalRequestType.ComputerUseApprovalRequest,
                _ => null,
            };
        }
    }
}