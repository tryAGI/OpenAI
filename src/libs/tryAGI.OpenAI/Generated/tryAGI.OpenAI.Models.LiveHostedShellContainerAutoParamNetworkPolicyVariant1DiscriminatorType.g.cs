
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Allowlist,
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType value)
        {
            return value switch
            {
                LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType.Allowlist => "allowlist",
                LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType.Allowlist,
                "disabled" => LiveHostedShellContainerAutoParamNetworkPolicyVariant1DiscriminatorType.Disabled,
                _ => null,
            };
        }
    }
}