
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: aws
    /// </summary>
    public enum AwsExternalKeyParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsExternalKeyParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsExternalKeyParamsType value)
        {
            return value switch
            {
                AwsExternalKeyParamsType.Aws => "aws",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsExternalKeyParamsType? ToEnum(string value)
        {
            return value switch
            {
                "aws" => AwsExternalKeyParamsType.Aws,
                _ => null,
            };
        }
    }
}