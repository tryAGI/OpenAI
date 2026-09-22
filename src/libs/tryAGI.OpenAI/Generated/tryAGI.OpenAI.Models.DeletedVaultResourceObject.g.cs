
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `vault.deleted`.<br/>
    /// Default Value: vault.deleted
    /// </summary>
    public enum DeletedVaultResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        VaultDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedVaultResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedVaultResourceObject value)
        {
            return value switch
            {
                DeletedVaultResourceObject.VaultDeleted => "vault.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedVaultResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "vault.deleted" => DeletedVaultResourceObject.VaultDeleted,
                _ => null,
            };
        }
    }
}