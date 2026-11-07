
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: oidc
    /// </summary>
    public enum CreatePlatformWorkloadIdentityProviderBodyType
    {
        /// <summary>
        ///
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePlatformWorkloadIdentityProviderBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePlatformWorkloadIdentityProviderBodyType value)
        {
            return value switch
            {
                CreatePlatformWorkloadIdentityProviderBodyType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePlatformWorkloadIdentityProviderBodyType? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => CreatePlatformWorkloadIdentityProviderBodyType.Oidc,
                _ => null,
            };
        }
    }
}