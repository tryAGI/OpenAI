
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTextResponseFormatConfigurationDiscriminatorType
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
    public static class BetaTextResponseFormatConfigurationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextResponseFormatConfigurationDiscriminatorType value)
        {
            return value switch
            {
                BetaTextResponseFormatConfigurationDiscriminatorType.JsonObject => "json_object",
                BetaTextResponseFormatConfigurationDiscriminatorType.JsonSchema => "json_schema",
                BetaTextResponseFormatConfigurationDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextResponseFormatConfigurationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => BetaTextResponseFormatConfigurationDiscriminatorType.JsonObject,
                "json_schema" => BetaTextResponseFormatConfigurationDiscriminatorType.JsonSchema,
                "text" => BetaTextResponseFormatConfigurationDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}