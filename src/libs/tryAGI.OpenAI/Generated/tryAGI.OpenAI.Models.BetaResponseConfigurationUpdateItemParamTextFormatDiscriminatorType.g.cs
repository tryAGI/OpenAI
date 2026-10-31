
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType
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
    public static class BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType.JsonSchema => "json_schema",
                BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType.JsonSchema,
                "text" => BetaResponseConfigurationUpdateItemParamTextFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}