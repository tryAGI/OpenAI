
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: browser_origin_access
    /// </summary>
    public enum ComputerUseApprovalResponseParamBrowserOriginAccessParamType
    {
        /// <summary>
        ///
        /// </summary>
        BrowserOriginAccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseParamBrowserOriginAccessParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseParamBrowserOriginAccessParamType value)
        {
            return value switch
            {
                ComputerUseApprovalResponseParamBrowserOriginAccessParamType.BrowserOriginAccess => "browser_origin_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseParamBrowserOriginAccessParamType? ToEnum(string value)
        {
            return value switch
            {
                "browser_origin_access" => ComputerUseApprovalResponseParamBrowserOriginAccessParamType.BrowserOriginAccess,
                _ => null,
            };
        }
    }
}