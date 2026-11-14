
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: service_account_default
    /// </summary>
    public enum DefaultPermissionsType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceAccountDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DefaultPermissionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DefaultPermissionsType value)
        {
            return value switch
            {
                DefaultPermissionsType.ServiceAccountDefault => "service_account_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DefaultPermissionsType? ToEnum(string value)
        {
            return value switch
            {
                "service_account_default" => DefaultPermissionsType.ServiceAccountDefault,
                _ => null,
            };
        }
    }
}