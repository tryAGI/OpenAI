
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `static_bearer`.<br/>
    /// Default Value: static_bearer
    /// </summary>
    public enum RotateVaultCredentialAuthParamStaticBearerType
    {
        /// <summary>
        ///
        /// </summary>
        StaticBearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateVaultCredentialAuthParamStaticBearerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateVaultCredentialAuthParamStaticBearerType value)
        {
            return value switch
            {
                RotateVaultCredentialAuthParamStaticBearerType.StaticBearer => "static_bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateVaultCredentialAuthParamStaticBearerType? ToEnum(string value)
        {
            return value switch
            {
                "static_bearer" => RotateVaultCredentialAuthParamStaticBearerType.StaticBearer,
                _ => null,
            };
        }
    }
}