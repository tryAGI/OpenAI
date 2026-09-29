
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `browser_origin_access`.<br/>
    /// Default Value: browser_origin_access
    /// </summary>
    public enum ComputerUseApprovalRequestKindResourceBrowserOriginAccessType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserOriginAccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalRequestKindResourceBrowserOriginAccessTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalRequestKindResourceBrowserOriginAccessType value)
        {
            return value switch
            {
                ComputerUseApprovalRequestKindResourceBrowserOriginAccessType.BrowserOriginAccess => "browser_origin_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalRequestKindResourceBrowserOriginAccessType? ToEnum(string value)
        {
            return value switch
            {
                "browser_origin_access" => ComputerUseApprovalRequestKindResourceBrowserOriginAccessType.BrowserOriginAccess,
                _ => null,
            };
        }
    }
}