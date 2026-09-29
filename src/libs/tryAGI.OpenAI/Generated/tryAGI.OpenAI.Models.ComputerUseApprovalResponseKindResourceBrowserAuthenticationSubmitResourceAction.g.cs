
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: submit
    /// </summary>
    public enum ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction
    {
        /// <summary>
        ///
        /// </summary>
        Submit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction value)
        {
            return value switch
            {
                ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction.Submit => "submit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction? ToEnum(string value)
        {
            return value switch
            {
                "submit" => ComputerUseApprovalResponseKindResourceBrowserAuthenticationSubmitResourceAction.Submit,
                _ => null,
            };
        }
    }
}