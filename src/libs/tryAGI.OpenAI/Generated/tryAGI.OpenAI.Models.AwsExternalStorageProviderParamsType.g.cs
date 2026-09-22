
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: aws
    /// </summary>
    public enum AwsExternalStorageProviderParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsExternalStorageProviderParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsExternalStorageProviderParamsType value)
        {
            return value switch
            {
                AwsExternalStorageProviderParamsType.Aws => "aws",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsExternalStorageProviderParamsType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => AwsExternalStorageProviderParamsType.Aws,
                _ => null,
            };
        }
    }
}