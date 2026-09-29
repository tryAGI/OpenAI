
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ComputerUseApprovalResponseKindResourceDiscriminatorAction
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
    public static class ComputerUseApprovalResponseKindResourceDiscriminatorActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseApprovalResponseKindResourceDiscriminatorAction value)
        {
            return value switch
            {
                ComputerUseApprovalResponseKindResourceDiscriminatorAction.Cancel => "cancel",
                ComputerUseApprovalResponseKindResourceDiscriminatorAction.Submit => "submit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseApprovalResponseKindResourceDiscriminatorAction? ToEnum(string value)
        {
            return value switch
            {
                "cancel" => ComputerUseApprovalResponseKindResourceDiscriminatorAction.Cancel,
                "submit" => ComputerUseApprovalResponseKindResourceDiscriminatorAction.Submit,
                _ => null,
            };
        }
    }
}