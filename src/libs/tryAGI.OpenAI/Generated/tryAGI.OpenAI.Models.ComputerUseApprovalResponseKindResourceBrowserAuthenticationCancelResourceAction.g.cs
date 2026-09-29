
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: cancel
    /// </summary>
    public enum ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction
    {
        /// <summary>
        ///
        /// </summary>
        Cancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction value)
        {
            return value switch
            {
                ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction.Cancel => "cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction? ToEnum(string value)
        {
            return value switch
            {
                "cancel" => ComputerUseApprovalResponseKindResourceBrowserAuthenticationCancelResourceAction.Cancel,
                _ => null,
            };
        }
    }
}