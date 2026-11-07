
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TextResponseFormatConfigurationDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        JsonObject,
        /// <summary>
        ///
        /// </summary>
        JsonSchema,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextResponseFormatConfigurationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextResponseFormatConfigurationDiscriminatorType value)
        {
            return value switch
            {
                TextResponseFormatConfigurationDiscriminatorType.JsonObject => "json_object",
                TextResponseFormatConfigurationDiscriminatorType.JsonSchema => "json_schema",
                TextResponseFormatConfigurationDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextResponseFormatConfigurationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => TextResponseFormatConfigurationDiscriminatorType.JsonObject,
                "json_schema" => TextResponseFormatConfigurationDiscriminatorType.JsonSchema,
                "text" => TextResponseFormatConfigurationDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}