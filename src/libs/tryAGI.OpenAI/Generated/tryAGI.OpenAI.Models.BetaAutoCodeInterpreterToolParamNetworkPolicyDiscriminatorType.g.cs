
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType
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
    public static class BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType value)
        {
            return value switch
            {
                BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType.Allowlist => "allowlist",
                BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType.Allowlist,
                "disabled" => BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType.Disabled,
                _ => null,
            };
        }
    }
}