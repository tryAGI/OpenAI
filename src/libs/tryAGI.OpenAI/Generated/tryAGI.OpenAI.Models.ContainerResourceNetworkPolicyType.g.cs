
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The network policy mode.
    /// </summary>
    public enum ContainerResourceNetworkPolicyType
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
    public static class ContainerResourceNetworkPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerResourceNetworkPolicyType value)
        {
            return value switch
            {
                ContainerResourceNetworkPolicyType.Allowlist => "allowlist",
                ContainerResourceNetworkPolicyType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerResourceNetworkPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => ContainerResourceNetworkPolicyType.Allowlist,
                "disabled" => ContainerResourceNetworkPolicyType.Disabled,
                _ => null,
            };
        }
    }
}