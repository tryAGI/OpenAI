
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseConfigurationUpdateTextFormatDiscriminatorType
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
    public static class BetaResponseConfigurationUpdateTextFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseConfigurationUpdateTextFormatDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseConfigurationUpdateTextFormatDiscriminatorType.JsonSchema => "json_schema",
                BetaResponseConfigurationUpdateTextFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseConfigurationUpdateTextFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => BetaResponseConfigurationUpdateTextFormatDiscriminatorType.JsonSchema,
                "text" => BetaResponseConfigurationUpdateTextFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}