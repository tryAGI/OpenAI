
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ComputerUseApprovalResponseParamDiscriminatorType
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
    public static class ComputerUseApprovalResponseParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseParamDiscriminatorType value)
        {
            return value switch
            {
                ComputerUseApprovalResponseParamDiscriminatorType.BrowserAuthentication => "browser_authentication",
                ComputerUseApprovalResponseParamDiscriminatorType.BrowserOriginAccess => "browser_origin_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "browser_authentication" => ComputerUseApprovalResponseParamDiscriminatorType.BrowserAuthentication,
                "browser_origin_access" => ComputerUseApprovalResponseParamDiscriminatorType.BrowserOriginAccess,
                _ => null,
            };
        }
    }
}