
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContainerAutoParamNetworkPolicyDiscriminatorType
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
    public static class BetaContainerAutoParamNetworkPolicyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerAutoParamNetworkPolicyDiscriminatorType value)
        {
            return value switch
            {
                BetaContainerAutoParamNetworkPolicyDiscriminatorType.Allowlist => "allowlist",
                BetaContainerAutoParamNetworkPolicyDiscriminatorType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerAutoParamNetworkPolicyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => BetaContainerAutoParamNetworkPolicyDiscriminatorType.Allowlist,
                "disabled" => BetaContainerAutoParamNetworkPolicyDiscriminatorType.Disabled,
                _ => null,
            };
        }
    }
}