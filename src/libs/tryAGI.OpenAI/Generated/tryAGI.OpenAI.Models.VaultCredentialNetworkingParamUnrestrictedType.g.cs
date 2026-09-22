
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `unrestricted`.<br/>
    /// Default Value: unrestricted
    /// </summary>
    public enum VaultCredentialNetworkingParamUnrestrictedType
    {
        /// <summary>
        ///
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialNetworkingParamUnrestrictedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialNetworkingParamUnrestrictedType value)
        {
            return value switch
            {
                VaultCredentialNetworkingParamUnrestrictedType.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialNetworkingParamUnrestrictedType? ToEnum(string value)
        {
            return value switch
            {
                "unrestricted" => VaultCredentialNetworkingParamUnrestrictedType.Unrestricted,
                _ => null,
            };
        }
    }
}