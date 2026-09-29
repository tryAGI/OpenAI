
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: browser_authentication
    /// </summary>
    public enum ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserAuthentication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType value)
        {
            return value switch
            {
                ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType.BrowserAuthentication => "browser_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType? ToEnum(string value)
        {
            return value switch
            {
                "browser_authentication" => ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceType.BrowserAuthentication,
                _ => null,
            };
        }
    }
}