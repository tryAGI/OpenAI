
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: restricted
    /// </summary>
    public enum RestrictedPermissionsParamType
    {
        /// <summary>
        ///
        /// </summary>
        Restricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RestrictedPermissionsParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RestrictedPermissionsParamType value)
        {
            return value switch
            {
                RestrictedPermissionsParamType.Restricted => "restricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RestrictedPermissionsParamType? ToEnum(string value)
        {
            return value switch
            {
                "restricted" => RestrictedPermissionsParamType.Restricted,
                _ => null,
            };
        }
    }
}