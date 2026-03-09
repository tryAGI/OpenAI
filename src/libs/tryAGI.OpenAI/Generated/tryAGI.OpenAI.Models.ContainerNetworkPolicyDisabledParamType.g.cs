
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Disable outbound network access. Always `disabled`.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum ContainerNetworkPolicyDisabledParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerNetworkPolicyDisabledParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerNetworkPolicyDisabledParamType value)
        {
            return value switch
            {
                ContainerNetworkPolicyDisabledParamType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerNetworkPolicyDisabledParamType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ContainerNetworkPolicyDisabledParamType.Disabled,
                _ => null,
            };
        }
    }
}