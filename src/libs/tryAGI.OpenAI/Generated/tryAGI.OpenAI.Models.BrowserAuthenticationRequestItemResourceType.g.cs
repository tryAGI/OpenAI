
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always computer_use_approval_request.<br/>
    /// Default Value: computer_use_approval_request
    /// </summary>
    public enum BrowserAuthenticationRequestItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerUseApprovalRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BrowserAuthenticationRequestItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrowserAuthenticationRequestItemResourceType value)
        {
            return value switch
            {
                BrowserAuthenticationRequestItemResourceType.ComputerUseApprovalRequest => "computer_use_approval_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrowserAuthenticationRequestItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "computer_use_approval_request" => BrowserAuthenticationRequestItemResourceType.ComputerUseApprovalRequest,
                _ => null,
            };
        }
    }
}