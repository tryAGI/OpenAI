
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseConfigurationUpdateTextFormatDiscriminatorType
    {
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
    public static class ResponseConfigurationUpdateTextFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseConfigurationUpdateTextFormatDiscriminatorType value)
        {
            return value switch
            {
                ResponseConfigurationUpdateTextFormatDiscriminatorType.JsonSchema => "json_schema",
                ResponseConfigurationUpdateTextFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseConfigurationUpdateTextFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ResponseConfigurationUpdateTextFormatDiscriminatorType.JsonSchema,
                "text" => ResponseConfigurationUpdateTextFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}