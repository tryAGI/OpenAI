
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TextFormatResourceDiscriminatorType
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
    public static class TextFormatResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextFormatResourceDiscriminatorType value)
        {
            return value switch
            {
                TextFormatResourceDiscriminatorType.JsonSchema => "json_schema",
                TextFormatResourceDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextFormatResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => TextFormatResourceDiscriminatorType.JsonSchema,
                "text" => TextFormatResourceDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}