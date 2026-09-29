
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: browser_authentication
    /// </summary>
    public enum ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserAuthentication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType value)
        {
            return value switch
            {
                ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType.BrowserAuthentication => "browser_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType? ToEnum(string value)
        {
            return value switch
            {
                "browser_authentication" => ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamType.BrowserAuthentication,
                _ => null,
            };
        }
    }
}