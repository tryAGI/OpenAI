
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: azure
    /// </summary>
    public enum AzureExternalStorageProviderParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureExternalStorageProviderParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureExternalStorageProviderParamsType value)
        {
            return value switch
            {
                AzureExternalStorageProviderParamsType.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureExternalStorageProviderParamsType? ToEnum(string value)
        {
            return value switch
            {
                "azure" => AzureExternalStorageProviderParamsType.Azure,
                _ => null,
            };
        }
    }
}