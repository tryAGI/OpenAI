
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum VaultCredentialNetworkingResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Limited,
        /// <summary>
        ///
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialNetworkingResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialNetworkingResourceDiscriminatorType value)
        {
            return value switch
            {
                VaultCredentialNetworkingResourceDiscriminatorType.Limited => "limited",
                VaultCredentialNetworkingResourceDiscriminatorType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialNetworkingResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "limited" => VaultCredentialNetworkingResourceDiscriminatorType.Limited,
                "unrestricted" => VaultCredentialNetworkingResourceDiscriminatorType.Unrestricted,
                _ => null,
            };
        }
    }
}