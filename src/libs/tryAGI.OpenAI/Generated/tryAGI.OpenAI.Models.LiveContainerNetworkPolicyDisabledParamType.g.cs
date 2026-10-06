
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Disable outbound network access. Always `disabled`.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum LiveContainerNetworkPolicyDisabledParamType
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveContainerNetworkPolicyDisabledParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveContainerNetworkPolicyDisabledParamType value)
        {
            return value switch
            {
                LiveContainerNetworkPolicyDisabledParamType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveContainerNetworkPolicyDisabledParamType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => LiveContainerNetworkPolicyDisabledParamType.Disabled,
                _ => null,
            };
        }
    }
}