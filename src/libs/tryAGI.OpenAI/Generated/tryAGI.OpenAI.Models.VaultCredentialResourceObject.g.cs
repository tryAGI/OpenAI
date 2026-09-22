
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `vault.credential`.<br/>
    /// Default Value: vault.credential
    /// </summary>
    public enum VaultCredentialResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        VaultCredential,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultCredentialResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultCredentialResourceObject value)
        {
            return value switch
            {
                VaultCredentialResourceObject.VaultCredential => "vault.credential",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultCredentialResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "vault.credential" => VaultCredentialResourceObject.VaultCredential,
                _ => null,
            };
        }
    }
}