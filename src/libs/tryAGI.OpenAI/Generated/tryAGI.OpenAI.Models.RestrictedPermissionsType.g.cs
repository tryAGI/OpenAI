
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: restricted
    /// </summary>
    public enum RestrictedPermissionsType
    {
        /// <summary>
        ///
        /// </summary>
        Restricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RestrictedPermissionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RestrictedPermissionsType value)
        {
            return value switch
            {
                RestrictedPermissionsType.Restricted => "restricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RestrictedPermissionsType? ToEnum(string value)
        {
            return value switch
            {
                "restricted" => RestrictedPermissionsType.Restricted,
                _ => null,
            };
        }
    }
}