
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContainerAutoParamNetworkPolicyDiscriminatorType
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
    public static class ContainerAutoParamNetworkPolicyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerAutoParamNetworkPolicyDiscriminatorType value)
        {
            return value switch
            {
                ContainerAutoParamNetworkPolicyDiscriminatorType.Allowlist => "allowlist",
                ContainerAutoParamNetworkPolicyDiscriminatorType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerAutoParamNetworkPolicyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => ContainerAutoParamNetworkPolicyDiscriminatorType.Allowlist,
                "disabled" => ContainerAutoParamNetworkPolicyDiscriminatorType.Disabled,
                _ => null,
            };
        }
    }
}