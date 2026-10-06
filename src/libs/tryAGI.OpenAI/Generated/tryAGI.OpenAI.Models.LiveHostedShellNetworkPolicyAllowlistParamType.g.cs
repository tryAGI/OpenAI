
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allow outbound network access only to specified domains. Always `allowlist`.<br/>
    /// Default Value: allowlist
    /// </summary>
    public enum LiveHostedShellNetworkPolicyAllowlistParamType
    {
        /// <summary>
        ///
        /// </summary>
        Allowlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveHostedShellNetworkPolicyAllowlistParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveHostedShellNetworkPolicyAllowlistParamType value)
        {
            return value switch
            {
                LiveHostedShellNetworkPolicyAllowlistParamType.Allowlist => "allowlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveHostedShellNetworkPolicyAllowlistParamType? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => LiveHostedShellNetworkPolicyAllowlistParamType.Allowlist,
                _ => null,
            };
        }
    }
}