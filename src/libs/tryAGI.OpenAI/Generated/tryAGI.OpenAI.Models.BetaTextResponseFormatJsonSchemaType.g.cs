
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of response format being defined. Always `json_schema`.
    /// </summary>
    public enum BetaTextResponseFormatJsonSchemaType
    {
        /// <summary>
        ///
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextResponseFormatJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextResponseFormatJsonSchemaType value)
        {
            return value switch
            {
                BetaTextResponseFormatJsonSchemaType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextResponseFormatJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => BetaTextResponseFormatJsonSchemaType.JsonSchema,
                _ => null,
            };
        }
    }
}