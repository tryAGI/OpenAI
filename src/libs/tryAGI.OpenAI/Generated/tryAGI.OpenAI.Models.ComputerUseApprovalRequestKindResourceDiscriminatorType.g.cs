
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ComputerUseApprovalRequestKindResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserAuthentication,
        /// <summary>
        ///
        /// </summary>
        BrowserOriginAccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalRequestKindResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalRequestKindResourceDiscriminatorType value)
        {
            return value switch
            {
                ComputerUseApprovalRequestKindResourceDiscriminatorType.BrowserAuthentication => "browser_authentication",
                ComputerUseApprovalRequestKindResourceDiscriminatorType.BrowserOriginAccess => "browser_origin_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalRequestKindResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "browser_authentication" => ComputerUseApprovalRequestKindResourceDiscriminatorType.BrowserAuthentication,
                "browser_origin_access" => ComputerUseApprovalRequestKindResourceDiscriminatorType.BrowserOriginAccess,
                _ => null,
            };
        }
    }
}