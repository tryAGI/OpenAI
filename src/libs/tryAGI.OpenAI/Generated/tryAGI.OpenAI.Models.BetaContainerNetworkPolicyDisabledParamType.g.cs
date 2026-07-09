
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Disable outbound network access. Always `disabled`.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum BetaContainerNetworkPolicyDisabledParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContainerNetworkPolicyDisabledParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerNetworkPolicyDisabledParamType value)
        {
            return value switch
            {
                BetaContainerNetworkPolicyDisabledParamType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerNetworkPolicyDisabledParamType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaContainerNetworkPolicyDisabledParamType.Disabled,
                _ => null,
            };
        }
    }
}