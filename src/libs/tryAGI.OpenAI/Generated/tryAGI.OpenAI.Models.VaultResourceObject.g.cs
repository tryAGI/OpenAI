
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `vault`.<br/>
    /// Default Value: vault
    /// </summary>
    public enum VaultResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        Vault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultResourceObject value)
        {
            return value switch
            {
                VaultResourceObject.Vault => "vault",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "vault" => VaultResourceObject.Vault,
                _ => null,
            };
        }
    }
}