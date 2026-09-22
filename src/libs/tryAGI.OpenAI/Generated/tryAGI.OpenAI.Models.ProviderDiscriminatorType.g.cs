
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ProviderDiscriminatorType
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
    public static class ProviderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderDiscriminatorType value)
        {
            return value switch
            {
                ProviderDiscriminatorType.Aws => "aws",
                ProviderDiscriminatorType.Azure => "azure",
                ProviderDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => ProviderDiscriminatorType.Aws,
                "azure" => ProviderDiscriminatorType.Azure,
                "gcp" => ProviderDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}