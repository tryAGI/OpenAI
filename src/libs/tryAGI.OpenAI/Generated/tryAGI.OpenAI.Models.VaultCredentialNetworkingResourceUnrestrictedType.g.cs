
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `unrestricted`.<br/>
    /// Default Value: unrestricted
    /// </summary>
    public enum VaultCredentialNetworkingResourceUnrestrictedType
    {
        /// <summary>
        ///
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialNetworkingResourceUnrestrictedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialNetworkingResourceUnrestrictedType value)
        {
            return value switch
            {
                VaultCredentialNetworkingResourceUnrestrictedType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialNetworkingResourceUnrestrictedType? ToEnum(string value)
        {
            return value switch
            {
                "unrestricted" => VaultCredentialNetworkingResourceUnrestrictedType.Unrestricted,
                _ => null,
            };
        }
    }
}