
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `list`.<br/>
    /// Default Value: list
    /// </summary>
    public enum VaultListResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultListResourceObject value)
        {
            return value switch
            {
                VaultListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => VaultListResourceObject.List,
                _ => null,
            };
        }
    }
}