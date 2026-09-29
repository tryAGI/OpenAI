
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: cancel
    /// </summary>
    public enum ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction
    {
        /// <summary>
        ///
        /// </summary>
        Cancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction value)
        {
            return value switch
            {
                ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction.Cancel => "cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction? ToEnum(string value)
        {
            return value switch
            {
                "cancel" => ComputerUseApprovalResponseParamBrowserAuthenticationCancelParamAction.Cancel,
                _ => null,
            };
        }
    }
}