
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: submit
    /// </summary>
    public enum ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction
    {
        /// <summary>
        ///
        /// </summary>
        Submit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction value)
        {
            return value switch
            {
                ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction.Submit => "submit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction? ToEnum(string value)
        {
            return value switch
            {
                "submit" => ComputerUseApprovalResponseParamBrowserAuthenticationSubmitParamAction.Submit,
                _ => null,
            };
        }
    }
}