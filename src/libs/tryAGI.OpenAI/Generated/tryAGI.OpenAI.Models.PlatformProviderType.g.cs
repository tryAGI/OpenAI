
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: oidc
    /// </summary>
    public enum PlatformProviderType
    {
        /// <summary>
        ///
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlatformProviderType value)
        {
            return value switch
            {
                PlatformProviderType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlatformProviderType? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => PlatformProviderType.Oidc,
                _ => null,
            };
        }
    }
}