
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction
    {
        /// <summary>
        ///
        /// </summary>
        Cancel,
        /// <summary>
        ///
        /// </summary>
        Submit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction value)
        {
            return value switch
            {
                ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction.Cancel => "cancel",
                ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction.Submit => "submit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction? ToEnum(string value)
        {
            return value switch
            {
                "cancel" => ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction.Cancel,
                "submit" => ComputerUseApprovalResponseParamBrowserAuthenticationDiscriminatorAction.Submit,
                _ => null,
            };
        }
    }
}