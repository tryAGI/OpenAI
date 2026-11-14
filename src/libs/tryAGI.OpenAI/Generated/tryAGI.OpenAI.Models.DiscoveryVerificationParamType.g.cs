
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: discovery
    /// </summary>
    public enum DiscoveryVerificationParamType
    {
        /// <summary>
        ///
        /// </summary>
        Discovery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiscoveryVerificationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscoveryVerificationParamType value)
        {
            return value switch
            {
                DiscoveryVerificationParamType.Discovery => "discovery",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscoveryVerificationParamType? ToEnum(string value)
        {
            return value switch
            {
                "discovery" => DiscoveryVerificationParamType.Discovery,
                _ => null,
            };
        }
    }
}