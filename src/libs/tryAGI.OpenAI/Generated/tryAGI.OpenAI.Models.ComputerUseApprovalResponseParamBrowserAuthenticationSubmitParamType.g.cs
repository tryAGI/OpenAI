
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: browser_authentication
    /// </summary>
    public enum ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserAuthentication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType value)
        {
            return value switch
            {
                ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType.BrowserAuthentication => "browser_authentication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType? ToEnum(string value)
        {
            return value switch
            {
                "browser_authentication" => ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamType.BrowserAuthentication,
                _ => null,
            };
        }
    }
}