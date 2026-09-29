
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: browser_authentication
    /// </summary>
    public enum ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserAuthentication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType value)
        {
            return value switch
            {
                ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType.BrowserAuthentication => "browser_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType? ToEnum(string value)
        {
            return value switch
            {
                "browser_authentication" => ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceType.BrowserAuthentication,
                _ => null,
            };
        }
    }
}