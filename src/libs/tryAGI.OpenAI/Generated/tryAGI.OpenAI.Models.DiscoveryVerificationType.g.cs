
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: discovery
    /// </summary>
    public enum DiscoveryVerificationType
    {
        /// <summary>
        ///
        /// </summary>
        Discovery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiscoveryVerificationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscoveryVerificationType value)
        {
            return value switch
            {
                DiscoveryVerificationType.Discovery => "discovery",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscoveryVerificationType? ToEnum(string value)
        {
            return value switch
            {
                "discovery" => DiscoveryVerificationType.Discovery,
                _ => null,
            };
        }
    }
}