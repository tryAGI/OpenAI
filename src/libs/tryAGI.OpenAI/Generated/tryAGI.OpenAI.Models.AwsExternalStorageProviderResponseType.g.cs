
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: aws
    /// </summary>
    public enum AwsExternalStorageProviderResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsExternalStorageProviderResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsExternalStorageProviderResponseType value)
        {
            return value switch
            {
                AwsExternalStorageProviderResponseType.Aws => "aws",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsExternalStorageProviderResponseType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => AwsExternalStorageProviderResponseType.Aws,
                _ => null,
            };
        }
    }
}