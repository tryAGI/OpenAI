
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: computer_use_approval_request_result
    /// </summary>
    public enum ComputerUseApprovalRequestResultItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerUseApprovalRequestResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalRequestResultItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalRequestResultItemResourceType value)
        {
            return value switch
            {
                ComputerUseApprovalRequestResultItemResourceType.ComputerUseApprovalRequestResult => "computer_use_approval_request_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalRequestResultItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_approval_request_result" => ComputerUseApprovalRequestResultItemResourceType.ComputerUseApprovalRequestResult,
                _ => null,
            };
        }
    }
}