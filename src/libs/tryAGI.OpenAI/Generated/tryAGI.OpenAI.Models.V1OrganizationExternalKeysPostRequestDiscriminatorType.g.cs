
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum V1OrganizationExternalKeysPostRequestDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
        /// <summary>
        ///
        /// </summary>
        Azure,
        /// <summary>
        ///
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1OrganizationExternalKeysPostRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OrganizationExternalKeysPostRequestDiscriminatorType value)
        {
            return value switch
            {
                V1OrganizationExternalKeysPostRequestDiscriminatorType.Aws => "aws",
                V1OrganizationExternalKeysPostRequestDiscriminatorType.Azure => "azure",
                V1OrganizationExternalKeysPostRequestDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OrganizationExternalKeysPostRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => V1OrganizationExternalKeysPostRequestDiscriminatorType.Aws,
                "azure" => V1OrganizationExternalKeysPostRequestDiscriminatorType.Azure,
                "gcp" => V1OrganizationExternalKeysPostRequestDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}