
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: azure
    /// </summary>
    public enum AzureExternalStorageProviderResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureExternalStorageProviderResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureExternalStorageProviderResponseType value)
        {
            return value switch
            {
                AzureExternalStorageProviderResponseType.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureExternalStorageProviderResponseType? ToEnum(string value)
        {
            return value switch
            {
                "azure" => AzureExternalStorageProviderResponseType.Azure,
                _ => null,
            };
        }
    }
}