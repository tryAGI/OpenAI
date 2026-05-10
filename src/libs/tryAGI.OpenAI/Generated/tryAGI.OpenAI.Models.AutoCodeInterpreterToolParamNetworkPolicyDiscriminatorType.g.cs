
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType
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
    public static class AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType value)
        {
            return value switch
            {
                AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType.Allowlist => "allowlist",
                AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType.Allowlist,
                "disabled" => AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType.Disabled,
                _ => null,
            };
        }
    }
}