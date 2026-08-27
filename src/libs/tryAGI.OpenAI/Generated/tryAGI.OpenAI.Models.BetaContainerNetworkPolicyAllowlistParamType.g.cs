
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allow outbound network access only to specified domains. Always `allowlist`.<br/>
    /// Default Value: allowlist
    /// </summary>
    public enum BetaContainerNetworkPolicyAllowlistParamType
    {
        /// <summary>
        ///
        /// </summary>
        Allowlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContainerNetworkPolicyAllowlistParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerNetworkPolicyAllowlistParamType value)
        {
            return value switch
            {
                BetaContainerNetworkPolicyAllowlistParamType.Allowlist => "allowlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerNetworkPolicyAllowlistParamType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => BetaContainerNetworkPolicyAllowlistParamType.Allowlist,
                _ => null,
            };
        }
    }
}