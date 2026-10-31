
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType
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
    public static class ResponseConfigurationUpdateItemParamTextFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType value)
        {
            return value switch
            {
                ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType.JsonSchema => "json_schema",
                ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType.JsonSchema,
                "text" => ResponseConfigurationUpdateItemParamTextFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}