
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: azure
    /// </summary>
    public enum AzureExternalKeyParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureExternalKeyParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureExternalKeyParamsType value)
        {
            return value switch
            {
                AzureExternalKeyParamsType.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureExternalKeyParamsType? ToEnum(string value)
        {
            return value switch
            {
                "azure" => AzureExternalKeyParamsType.Azure,
                _ => null,
            };
        }
    }
}