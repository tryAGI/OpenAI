
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateExternalStorageBodyProviderDiscriminatorType
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
    public static class CreateExternalStorageBodyProviderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExternalStorageBodyProviderDiscriminatorType value)
        {
            return value switch
            {
                CreateExternalStorageBodyProviderDiscriminatorType.Aws => "aws",
                CreateExternalStorageBodyProviderDiscriminatorType.Azure => "azure",
                CreateExternalStorageBodyProviderDiscriminatorType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExternalStorageBodyProviderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => CreateExternalStorageBodyProviderDiscriminatorType.Aws,
                "azure" => CreateExternalStorageBodyProviderDiscriminatorType.Azure,
                "gcp" => CreateExternalStorageBodyProviderDiscriminatorType.Gcp,
                _ => null,
            };
        }
    }
}