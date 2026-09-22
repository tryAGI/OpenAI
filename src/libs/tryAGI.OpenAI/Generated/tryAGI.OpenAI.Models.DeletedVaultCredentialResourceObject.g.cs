
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `vault.credential.deleted`.<br/>
    /// Default Value: vault.credential.deleted
    /// </summary>
    public enum DeletedVaultCredentialResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        VaultCredentialDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedVaultCredentialResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedVaultCredentialResourceObject value)
        {
            return value switch
            {
                DeletedVaultCredentialResourceObject.VaultCredentialDeleted => "vault.credential.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedVaultCredentialResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "vault.credential.deleted" => DeletedVaultCredentialResourceObject.VaultCredentialDeleted,
                _ => null,
            };
        }
    }
}