
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `json_schema`.<br/>
    /// Default Value: json_schema
    /// </summary>
    public enum TextFormatResourceJsonSchemaType
    {
        /// <summary>
        ///
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextFormatResourceJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextFormatResourceJsonSchemaType value)
        {
            return value switch
            {
                TextFormatResourceJsonSchemaType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextFormatResourceJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => TextFormatResourceJsonSchemaType.JsonSchema,
                _ => null,
            };
        }
    }
}