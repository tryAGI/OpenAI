
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalStorageResponseProviderDiscriminatorType
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
    public static class ExternalStorageResponseProviderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalStorageResponseProviderDiscriminatorType value)
        {
            return value switch
            {
                ExternalStorageResponseProviderDiscriminatorType.Aws => "aws",
                ExternalStorageResponseProviderDiscriminatorType.Azure => "azure",
                ExternalStorageResponseProviderDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalStorageResponseProviderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => ExternalStorageResponseProviderDiscriminatorType.Aws,
                "azure" => ExternalStorageResponseProviderDiscriminatorType.Azure,
                "gcp" => ExternalStorageResponseProviderDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}